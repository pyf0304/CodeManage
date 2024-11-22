﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsProvinceBLEx
 表名:RsProvince(01120107)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 12:10:53
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
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
public static class clsRsProvinceBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objRsProvinceENS">源对象</param>
 /// <returns>目标对象=>clsRsProvinceEN:objRsProvinceENT</returns>
 public static clsRsProvinceENEx CopyToEx(this clsRsProvinceEN objRsProvinceENS)
{
try
{
 clsRsProvinceENEx objRsProvinceENT = new clsRsProvinceENEx();
clsRsProvinceBL.RsProvinceDA.CopyTo(objRsProvinceENS, objRsProvinceENT);
 return objRsProvinceENT;
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
 /// <param name = "objRsProvinceENS">源对象</param>
 /// <returns>目标对象=>clsRsProvinceEN:objRsProvinceENT</returns>
 public static clsRsProvinceEN CopyTo(this clsRsProvinceENEx objRsProvinceENS)
{
try
{
 clsRsProvinceEN objRsProvinceENT = new clsRsProvinceEN();
clsRsProvinceBL.CopyTo(objRsProvinceENS, objRsProvinceENT);
 return objRsProvinceENT;
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
 /// 省份(RsProvince)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsRsProvinceBLEx : clsRsProvinceBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsRsProvinceDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsRsProvinceDAEx RsProvinceDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsRsProvinceDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objRsProvinceENS">源对象</param>
 /// <returns>目标对象=>clsRsProvinceEN:objRsProvinceENT</returns>
 public static clsRsProvinceENEx CopyToEx(clsRsProvinceEN objRsProvinceENS)
{
try
{
 clsRsProvinceENEx objRsProvinceENT = new clsRsProvinceENEx();
clsRsProvinceBL.RsProvinceDA.CopyTo(objRsProvinceENS, objRsProvinceENT);
 return objRsProvinceENT;
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
public static List<clsRsProvinceENEx> GetObjExLst(string strCondition)
{
List <clsRsProvinceEN> arrObjLst = clsRsProvinceBL.GetObjLst(strCondition);
List <clsRsProvinceENEx> arrObjExLst = new List<clsRsProvinceENEx>();
foreach (clsRsProvinceEN objInFor in arrObjLst)
{
clsRsProvinceENEx objRsProvinceENEx = new clsRsProvinceENEx();
clsRsProvinceBL.CopyTo(objInFor, objRsProvinceENEx);
arrObjExLst.Add(objRsProvinceENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_Province">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsRsProvinceENEx GetObjExByid_Province(string strid_Province)
{
clsRsProvinceEN objRsProvinceEN = clsRsProvinceBL.GetObjByIdProvince(strid_Province);
clsRsProvinceENEx objRsProvinceENEx = new clsRsProvinceENEx();
clsRsProvinceBL.CopyTo(objRsProvinceEN, objRsProvinceENEx);
return objRsProvinceENEx;
}
}
}