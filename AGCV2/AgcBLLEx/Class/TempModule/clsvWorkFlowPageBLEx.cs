﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWorkFlowPageBLEx
 表名:vWorkFlowPage(00050489)
 生成代码版本:2019.08.26.1
 生成日期:2019/08/26 00:46:55
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:临时模块
 模块英文名:TempModule
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
public static class clsvWorkFlowPageBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvWorkFlowPageENS">源对象</param>
 /// <returns>目标对象=>clsvWorkFlowPageEN:objvWorkFlowPageENT</returns>
 public static clsvWorkFlowPageENEx CopyToEx(this clsvWorkFlowPageEN objvWorkFlowPageENS)
{
try
{
 clsvWorkFlowPageENEx objvWorkFlowPageENT = new clsvWorkFlowPageENEx();
clsvWorkFlowPageBL.CopyTo(objvWorkFlowPageENS, objvWorkFlowPageENT);
 return objvWorkFlowPageENT;
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
 /// <param name = "objvWorkFlowPageENS">源对象</param>
 /// <returns>目标对象=>clsvWorkFlowPageEN:objvWorkFlowPageENT</returns>
 public static clsvWorkFlowPageEN CopyTo(this clsvWorkFlowPageENEx objvWorkFlowPageENS)
{
try
{
 clsvWorkFlowPageEN objvWorkFlowPageENT = new clsvWorkFlowPageEN();
clsvWorkFlowPageBL.CopyTo(objvWorkFlowPageENS, objvWorkFlowPageENT);
 return objvWorkFlowPageENT;
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
 /// vWorkFlowPage(vWorkFlowPage)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvWorkFlowPageBLEx : clsvWorkFlowPageBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvWorkFlowPageDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvWorkFlowPageDAEx vWorkFlowPageDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvWorkFlowPageDAEx();
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
public static List<clsvWorkFlowPageENEx> GetObjExLst(string strCondition)
{
List <clsvWorkFlowPageEN> arrObjLst = clsvWorkFlowPageBL.GetObjLst(strCondition);
List <clsvWorkFlowPageENEx> arrObjExLst = new List<clsvWorkFlowPageENEx>();
foreach (clsvWorkFlowPageEN objInFor in arrObjLst)
{
clsvWorkFlowPageENEx objvWorkFlowPageENEx = new clsvWorkFlowPageENEx();
clsvWorkFlowPageBL.CopyTo(objInFor, objvWorkFlowPageENEx);
arrObjExLst.Add(objvWorkFlowPageENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvWorkFlowPageENEx GetObjExBymId(long lngmId)
{
clsvWorkFlowPageEN objvWorkFlowPageEN = clsvWorkFlowPageBL.GetObjBymId(lngmId);
clsvWorkFlowPageENEx objvWorkFlowPageENEx = new clsvWorkFlowPageENEx();
clsvWorkFlowPageBL.CopyTo(objvWorkFlowPageEN, objvWorkFlowPageENEx);
return objvWorkFlowPageENEx;
}
}
}