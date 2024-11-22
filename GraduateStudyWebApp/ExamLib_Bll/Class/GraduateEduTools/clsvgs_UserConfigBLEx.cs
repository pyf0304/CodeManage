﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_UserConfigBLEx
 表名:vgs_UserConfig(01120691)
 生成代码版本:2020.06.27.2
 生成日期:2020/07/06 20:26:32
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
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
public static class clsvgs_UserConfigBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_UserConfigENS">源对象</param>
 /// <returns>目标对象=>clsvgs_UserConfigEN:objvgs_UserConfigENT</returns>
 public static clsvgs_UserConfigENEx CopyToEx(this clsvgs_UserConfigEN objvgs_UserConfigENS)
{
try
{
 clsvgs_UserConfigENEx objvgs_UserConfigENT = new clsvgs_UserConfigENEx();
clsvgs_UserConfigBL.vgs_UserConfigDA.CopyTo(objvgs_UserConfigENS, objvgs_UserConfigENT);
 return objvgs_UserConfigENT;
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
 /// <param name = "objvgs_UserConfigENS">源对象</param>
 /// <returns>目标对象=>clsvgs_UserConfigEN:objvgs_UserConfigENT</returns>
 public static clsvgs_UserConfigEN CopyTo(this clsvgs_UserConfigENEx objvgs_UserConfigENS)
{
try
{
 clsvgs_UserConfigEN objvgs_UserConfigENT = new clsvgs_UserConfigEN();
clsvgs_UserConfigBL.CopyTo(objvgs_UserConfigENS, objvgs_UserConfigENT);
 return objvgs_UserConfigENT;
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
 /// 用户配置视图(vgs_UserConfig)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_UserConfigBLEx : clsvgs_UserConfigBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_UserConfigDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_UserConfigDAEx vgs_UserConfigDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_UserConfigDAEx();
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
public static List<clsvgs_UserConfigENEx> GetObjExLst(string strCondition)
{
List <clsvgs_UserConfigEN> arrObjLst = clsvgs_UserConfigBL.GetObjLst(strCondition);
List <clsvgs_UserConfigENEx> arrObjExLst = new List<clsvgs_UserConfigENEx>();
foreach (clsvgs_UserConfigEN objInFor in arrObjLst)
{
clsvgs_UserConfigENEx objvgs_UserConfigENEx = new clsvgs_UserConfigENEx();
clsvgs_UserConfigBL.CopyTo(objInFor, objvgs_UserConfigENEx);
arrObjExLst.Add(objvgs_UserConfigENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngConfigId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_UserConfigENEx GetObjExByConfigId(long lngConfigId)
{
clsvgs_UserConfigEN objvgs_UserConfigEN = clsvgs_UserConfigBL.GetObjByConfigId(lngConfigId);
clsvgs_UserConfigENEx objvgs_UserConfigENEx = new clsvgs_UserConfigENEx();
clsvgs_UserConfigBL.CopyTo(objvgs_UserConfigEN, objvgs_UserConfigENEx);
return objvgs_UserConfigENEx;
}
}
}