﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDetailRegionFldsBLEx
 表名:vDetailRegionFlds(00050546)
 生成代码版本:2020.05.24.1
 生成日期:2020/05/26 02:27:21
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
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
public static class clsvDetailRegionFldsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvDetailRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsvDetailRegionFldsEN:objvDetailRegionFldsENT</returns>
 public static clsvDetailRegionFldsENEx CopyToEx(this clsvDetailRegionFldsEN objvDetailRegionFldsENS)
{
try
{
 clsvDetailRegionFldsENEx objvDetailRegionFldsENT = new clsvDetailRegionFldsENEx();
clsvDetailRegionFldsBL.vDetailRegionFldsDA.CopyTo(objvDetailRegionFldsENS, objvDetailRegionFldsENT);
 return objvDetailRegionFldsENT;
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
 /// <param name = "objvDetailRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsvDetailRegionFldsEN:objvDetailRegionFldsENT</returns>
 public static clsvDetailRegionFldsEN CopyTo(this clsvDetailRegionFldsENEx objvDetailRegionFldsENS)
{
try
{
 clsvDetailRegionFldsEN objvDetailRegionFldsENT = new clsvDetailRegionFldsEN();
clsvDetailRegionFldsBL.CopyTo(objvDetailRegionFldsENS, objvDetailRegionFldsENT);
 return objvDetailRegionFldsENT;
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
 /// v详细区域字段(vDetailRegionFlds)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvDetailRegionFldsBLEx : clsvDetailRegionFldsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvDetailRegionFldsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvDetailRegionFldsDAEx vDetailRegionFldsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvDetailRegionFldsDAEx();
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
public static List<clsvDetailRegionFldsENEx> GetObjExLst(string strCondition)
{
List <clsvDetailRegionFldsEN> arrObjLst = clsvDetailRegionFldsBL.GetObjLst(strCondition);
List <clsvDetailRegionFldsENEx> arrObjExLst = new List<clsvDetailRegionFldsENEx>();
foreach (clsvDetailRegionFldsEN objInFor in arrObjLst)
{
clsvDetailRegionFldsENEx objvDetailRegionFldsENEx = new clsvDetailRegionFldsENEx();
clsvDetailRegionFldsBL.CopyTo(objInFor, objvDetailRegionFldsENEx);
arrObjExLst.Add(objvDetailRegionFldsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvDetailRegionFldsENEx GetObjExBymId(long lngmId)
{
clsvDetailRegionFldsEN objvDetailRegionFldsEN = clsvDetailRegionFldsBL.GetObjBymId(lngmId);
clsvDetailRegionFldsENEx objvDetailRegionFldsENEx = new clsvDetailRegionFldsENEx();
clsvDetailRegionFldsBL.CopyTo(objvDetailRegionFldsEN, objvDetailRegionFldsENEx);
return objvDetailRegionFldsENEx;
}
}
}