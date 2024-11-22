﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TotalDataStatisticsBLEx
 表名:vzx_TotalDataStatistics(01120841)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:57:52
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置
 模块英文名:GraduateEduTools
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
public static class clsvzx_TotalDataStatisticsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TotalDataStatisticsEN:objvzx_TotalDataStatisticsENT</returns>
 public static clsvzx_TotalDataStatisticsENEx CopyToEx(this clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsENS)
{
try
{
 clsvzx_TotalDataStatisticsENEx objvzx_TotalDataStatisticsENT = new clsvzx_TotalDataStatisticsENEx();
clsvzx_TotalDataStatisticsBL.vzx_TotalDataStatisticsDA.CopyTo(objvzx_TotalDataStatisticsENS, objvzx_TotalDataStatisticsENT);
 return objvzx_TotalDataStatisticsENT;
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
 /// <param name = "objvzx_TotalDataStatisticsENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TotalDataStatisticsEN:objvzx_TotalDataStatisticsENT</returns>
 public static clsvzx_TotalDataStatisticsEN CopyTo(this clsvzx_TotalDataStatisticsENEx objvzx_TotalDataStatisticsENS)
{
try
{
 clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsENT = new clsvzx_TotalDataStatisticsEN();
clsvzx_TotalDataStatisticsBL.CopyTo(objvzx_TotalDataStatisticsENS, objvzx_TotalDataStatisticsENT);
 return objvzx_TotalDataStatisticsENT;
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
 /// vzx_TotalDataStatistics(vzx_TotalDataStatistics)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_TotalDataStatisticsBLEx : clsvzx_TotalDataStatisticsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_TotalDataStatisticsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_TotalDataStatisticsDAEx vzx_TotalDataStatisticsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_TotalDataStatisticsDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvzx_TotalDataStatisticsENEx> GetObjExLst(string strCondition)
{
List <clsvzx_TotalDataStatisticsEN> arrObjLst = clsvzx_TotalDataStatisticsBL.GetObjLst(strCondition);
List <clsvzx_TotalDataStatisticsENEx> arrObjExLst = new List<clsvzx_TotalDataStatisticsENEx>();
foreach (clsvzx_TotalDataStatisticsEN objInFor in arrObjLst)
{
clsvzx_TotalDataStatisticsENEx objvzx_TotalDataStatisticsENEx = new clsvzx_TotalDataStatisticsENEx();
clsvzx_TotalDataStatisticsBL.CopyTo(objInFor, objvzx_TotalDataStatisticsENEx);
arrObjExLst.Add(objvzx_TotalDataStatisticsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTotalDataId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_TotalDataStatisticsENEx GetObjExByTotalDataId(string strTotalDataId)
{
clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = clsvzx_TotalDataStatisticsBL.GetObjByTotalDataId(strTotalDataId);
clsvzx_TotalDataStatisticsENEx objvzx_TotalDataStatisticsENEx = new clsvzx_TotalDataStatisticsENEx();
clsvzx_TotalDataStatisticsBL.CopyTo(objvzx_TotalDataStatisticsEN, objvzx_TotalDataStatisticsENEx);
return objvzx_TotalDataStatisticsENEx;
}
}
}