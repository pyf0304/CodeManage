﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFuncRela_GroupByTtlBLEx
 表名:vFeatureFuncRela_GroupByTtl(00050537)
 生成代码版本:2020.03.20.1
 生成日期:2020/03/26 08:44:19
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:函数管理
 模块英文名:PrjFunction
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
public static class clsvFeatureFuncRela_GroupByTtlBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvFeatureFuncRela_GroupByTtlENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureFuncRela_GroupByTtlEN:objvFeatureFuncRela_GroupByTtlENT</returns>
 public static clsvFeatureFuncRela_GroupByTtlENEx CopyToEx(this clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlENS)
{
try
{
 clsvFeatureFuncRela_GroupByTtlENEx objvFeatureFuncRela_GroupByTtlENT = new clsvFeatureFuncRela_GroupByTtlENEx();
clsvFeatureFuncRela_GroupByTtlBL.vFeatureFuncRela_GroupByTtlDA.CopyTo(objvFeatureFuncRela_GroupByTtlENS, objvFeatureFuncRela_GroupByTtlENT);
 return objvFeatureFuncRela_GroupByTtlENT;
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
 /// <param name = "objvFeatureFuncRela_GroupByTtlENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureFuncRela_GroupByTtlEN:objvFeatureFuncRela_GroupByTtlENT</returns>
 public static clsvFeatureFuncRela_GroupByTtlEN CopyTo(this clsvFeatureFuncRela_GroupByTtlENEx objvFeatureFuncRela_GroupByTtlENS)
{
try
{
 clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlENT = new clsvFeatureFuncRela_GroupByTtlEN();
clsvFeatureFuncRela_GroupByTtlBL.CopyTo(objvFeatureFuncRela_GroupByTtlENS, objvFeatureFuncRela_GroupByTtlENT);
 return objvFeatureFuncRela_GroupByTtlENT;
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
 /// v功能函数关系_分类汇总(vFeatureFuncRela_GroupByTtl)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvFeatureFuncRela_GroupByTtlBLEx : clsvFeatureFuncRela_GroupByTtlBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvFeatureFuncRela_GroupByTtlDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvFeatureFuncRela_GroupByTtlDAEx vFeatureFuncRela_GroupByTtlDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvFeatureFuncRela_GroupByTtlDAEx();
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
public static List<clsvFeatureFuncRela_GroupByTtlENEx> GetObjExLst(string strCondition)
{
List <clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = clsvFeatureFuncRela_GroupByTtlBL.GetObjLst(strCondition);
List <clsvFeatureFuncRela_GroupByTtlENEx> arrObjExLst = new List<clsvFeatureFuncRela_GroupByTtlENEx>();
foreach (clsvFeatureFuncRela_GroupByTtlEN objInFor in arrObjLst)
{
clsvFeatureFuncRela_GroupByTtlENEx objvFeatureFuncRela_GroupByTtlENEx = new clsvFeatureFuncRela_GroupByTtlENEx();
clsvFeatureFuncRela_GroupByTtlBL.CopyTo(objInFor, objvFeatureFuncRela_GroupByTtlENEx);
arrObjExLst.Add(objvFeatureFuncRela_GroupByTtlENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvFeatureFuncRela_GroupByTtlENEx GetObjExByFeatureId(string strFeatureId)
{
clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = clsvFeatureFuncRela_GroupByTtlBL.GetObjByFeatureId(strFeatureId);
clsvFeatureFuncRela_GroupByTtlENEx objvFeatureFuncRela_GroupByTtlENEx = new clsvFeatureFuncRela_GroupByTtlENEx();
clsvFeatureFuncRela_GroupByTtlBL.CopyTo(objvFeatureFuncRela_GroupByTtlEN, objvFeatureFuncRela_GroupByTtlENEx);
return objvFeatureFuncRela_GroupByTtlENEx;
}
}
}