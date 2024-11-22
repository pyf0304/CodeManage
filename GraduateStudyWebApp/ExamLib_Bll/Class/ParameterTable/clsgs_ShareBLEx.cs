﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ShareBLEx
 表名:gs_Share(01120694)
 生成代码版本:2020.06.27.2
 生成日期:2020/07/06 20:26:22
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培参数
 模块英文名:ParameterTable
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
public static class clsgs_ShareBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_ShareENS">源对象</param>
 /// <returns>目标对象=>clsgs_ShareEN:objgs_ShareENT</returns>
 public static clsgs_ShareENEx CopyToEx(this clsgs_ShareEN objgs_ShareENS)
{
try
{
 clsgs_ShareENEx objgs_ShareENT = new clsgs_ShareENEx();
clsgs_ShareBL.gs_ShareDA.CopyTo(objgs_ShareENS, objgs_ShareENT);
 return objgs_ShareENT;
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
 /// <param name = "objgs_ShareENS">源对象</param>
 /// <returns>目标对象=>clsgs_ShareEN:objgs_ShareENT</returns>
 public static clsgs_ShareEN CopyTo(this clsgs_ShareENEx objgs_ShareENS)
{
try
{
 clsgs_ShareEN objgs_ShareENT = new clsgs_ShareEN();
clsgs_ShareBL.CopyTo(objgs_ShareENS, objgs_ShareENT);
 return objgs_ShareENT;
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
 /// 分享表(gs_Share)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_ShareBLEx : clsgs_ShareBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_ShareDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_ShareDAEx gs_ShareDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_ShareDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_ShareENS">源对象</param>
 /// <returns>目标对象=>clsgs_ShareEN:objgs_ShareENT</returns>
 public static clsgs_ShareENEx CopyToEx(clsgs_ShareEN objgs_ShareENS)
{
try
{
 clsgs_ShareENEx objgs_ShareENT = new clsgs_ShareENEx();
clsgs_ShareBL.gs_ShareDA.CopyTo(objgs_ShareENS, objgs_ShareENT);
 return objgs_ShareENT;
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
public static List<clsgs_ShareENEx> GetObjExLst(string strCondition)
{
List <clsgs_ShareEN> arrObjLst = clsgs_ShareBL.GetObjLst(strCondition);
List <clsgs_ShareENEx> arrObjExLst = new List<clsgs_ShareENEx>();
foreach (clsgs_ShareEN objInFor in arrObjLst)
{
clsgs_ShareENEx objgs_ShareENEx = new clsgs_ShareENEx();
clsgs_ShareBL.CopyTo(objInFor, objgs_ShareENEx);
arrObjExLst.Add(objgs_ShareENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strShareId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_ShareENEx GetObjExByShareId(string strShareId)
{
clsgs_ShareEN objgs_ShareEN = clsgs_ShareBL.GetObjByShareId(strShareId);
clsgs_ShareENEx objgs_ShareENEx = new clsgs_ShareENEx();
clsgs_ShareBL.CopyTo(objgs_ShareEN, objgs_ShareENEx);
return objgs_ShareENEx;
}
}
}