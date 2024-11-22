﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFuncParaRelaBLEx
 表名:vCMFuncParaRela(00050509)
 生成代码版本:2019.10.24.1
 生成日期:2019/11/02 23:16:40
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理
 模块英文名:CodeMan
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
public static class clsvCMFuncParaRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaENS">源对象</param>
 /// <returns>目标对象=>clsvCMFuncParaRelaEN:objvCMFuncParaRelaENT</returns>
 public static clsvCMFuncParaRelaENEx CopyToEx(this clsvCMFuncParaRelaEN objvCMFuncParaRelaENS)
{
try
{
 clsvCMFuncParaRelaENEx objvCMFuncParaRelaENT = new clsvCMFuncParaRelaENEx();
clsvCMFuncParaRelaBL.CopyTo(objvCMFuncParaRelaENS, objvCMFuncParaRelaENT);
 return objvCMFuncParaRelaENT;
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
 /// <param name = "objvCMFuncParaRelaENS">源对象</param>
 /// <returns>目标对象=>clsvCMFuncParaRelaEN:objvCMFuncParaRelaENT</returns>
 public static clsvCMFuncParaRelaEN CopyTo(this clsvCMFuncParaRelaENEx objvCMFuncParaRelaENS)
{
try
{
 clsvCMFuncParaRelaEN objvCMFuncParaRelaENT = new clsvCMFuncParaRelaEN();
clsvCMFuncParaRelaBL.CopyTo(objvCMFuncParaRelaENS, objvCMFuncParaRelaENT);
 return objvCMFuncParaRelaENT;
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
 /// vCMFuncParaRela(vCMFuncParaRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvCMFuncParaRelaBLEx : clsvCMFuncParaRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvCMFuncParaRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvCMFuncParaRelaDAEx vCMFuncParaRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvCMFuncParaRelaDAEx();
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
public static List<clsvCMFuncParaRelaENEx> GetObjExLst(string strCondition)
{
List <clsvCMFuncParaRelaEN> arrObjLst = clsvCMFuncParaRelaBL.GetObjLst(strCondition);
List <clsvCMFuncParaRelaENEx> arrObjExLst = new List<clsvCMFuncParaRelaENEx>();
foreach (clsvCMFuncParaRelaEN objInFor in arrObjLst)
{
clsvCMFuncParaRelaENEx objvCMFuncParaRelaENEx = new clsvCMFuncParaRelaENEx();
clsvCMFuncParaRelaBL.CopyTo(objInFor, objvCMFuncParaRelaENEx);
arrObjExLst.Add(objvCMFuncParaRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvCMFuncParaRelaENEx GetObjExBymId(long lngmId)
{
clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = clsvCMFuncParaRelaBL.GetObjBymId(lngmId);
clsvCMFuncParaRelaENEx objvCMFuncParaRelaENEx = new clsvCMFuncParaRelaENEx();
clsvCMFuncParaRelaBL.CopyTo(objvCMFuncParaRelaEN, objvCMFuncParaRelaENEx);
return objvCMFuncParaRelaENEx;
}
}
}