﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsValueGivingModeBLEx
 表名:ValueGivingMode(00050462)
 生成代码版本:2019.05.05.1
 生成日期:2019/05/06 08:23:13
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码
 模块英文名:GeneCode
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


using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
public static class clsValueGivingModeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objValueGivingModeENS">源对象</param>
 /// <returns>目标对象=>clsValueGivingModeEN:objValueGivingModeENT</returns>
 public static clsValueGivingModeENEx CopyToEx(this clsValueGivingModeEN objValueGivingModeENS)
{
try
{
 clsValueGivingModeENEx objValueGivingModeENT = new clsValueGivingModeENEx();
clsValueGivingModeBL.CopyTo(objValueGivingModeENS, objValueGivingModeENT);
 return objValueGivingModeENT;
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
 /// <param name = "objValueGivingModeENS">源对象</param>
 /// <returns>目标对象=>clsValueGivingModeEN:objValueGivingModeENT</returns>
 public static clsValueGivingModeEN CopyTo(this clsValueGivingModeENEx objValueGivingModeENS)
{
try
{
 clsValueGivingModeEN objValueGivingModeENT = new clsValueGivingModeEN();
clsValueGivingModeBL.CopyTo(objValueGivingModeENS, objValueGivingModeENT);
 return objValueGivingModeENT;
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
 /// 给值方式(ValueGivingMode)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsValueGivingModeBLEx : clsValueGivingModeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsValueGivingModeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsValueGivingModeDAEx ValueGivingModeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsValueGivingModeDAEx();
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
public static List<clsValueGivingModeENEx> GetObjExLst(string strCondition)
{
List <clsValueGivingModeEN> arrObjLst = clsValueGivingModeBL.GetObjLst(strCondition);
List <clsValueGivingModeENEx> arrObjExLst = new List<clsValueGivingModeENEx>();
foreach (clsValueGivingModeEN objInFor in arrObjLst)
{
clsValueGivingModeENEx objValueGivingModeENEx = new clsValueGivingModeENEx();
clsValueGivingModeBL.CopyTo(objInFor, objValueGivingModeENEx);
arrObjExLst.Add(objValueGivingModeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strValueGivingModeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsValueGivingModeENEx GetObjExByValueGivingModeId(string strValueGivingModeId)
{
clsValueGivingModeEN objValueGivingModeEN = clsValueGivingModeBL.GetObjByValueGivingModeId(strValueGivingModeId);
clsValueGivingModeENEx objValueGivingModeENEx = new clsValueGivingModeENEx();
clsValueGivingModeBL.CopyTo(objValueGivingModeEN, objValueGivingModeENEx);
return objValueGivingModeENEx;
}
}
}