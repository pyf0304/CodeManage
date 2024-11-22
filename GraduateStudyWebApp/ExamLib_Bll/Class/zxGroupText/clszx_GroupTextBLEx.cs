﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_GroupTextBLEx
 表名:zx_GroupText(01120734)
 生成代码版本:2020.09.09.1
 生成日期:2020/09/14 15:28:43
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文
 模块英文名:zxGroupText
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
public static class clszx_GroupTextBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_GroupTextENS">源对象</param>
 /// <returns>目标对象=>clszx_GroupTextEN:objzx_GroupTextENT</returns>
 public static clszx_GroupTextENEx CopyToEx(this clszx_GroupTextEN objzx_GroupTextENS)
{
try
{
 clszx_GroupTextENEx objzx_GroupTextENT = new clszx_GroupTextENEx();
clszx_GroupTextBL.zx_GroupTextDA.CopyTo(objzx_GroupTextENS, objzx_GroupTextENT);
 return objzx_GroupTextENT;
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
 /// <param name = "objzx_GroupTextENS">源对象</param>
 /// <returns>目标对象=>clszx_GroupTextEN:objzx_GroupTextENT</returns>
 public static clszx_GroupTextEN CopyTo(this clszx_GroupTextENEx objzx_GroupTextENS)
{
try
{
 clszx_GroupTextEN objzx_GroupTextENT = new clszx_GroupTextEN();
clszx_GroupTextBL.CopyTo(objzx_GroupTextENS, objzx_GroupTextENT);
 return objzx_GroupTextENT;
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
 /// 中学小组表(zx_GroupText)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_GroupTextBLEx : clszx_GroupTextBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_GroupTextDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_GroupTextDAEx zx_GroupTextDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_GroupTextDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_GroupTextENS">源对象</param>
 /// <returns>目标对象=>clszx_GroupTextEN:objzx_GroupTextENT</returns>
 public static clszx_GroupTextENEx CopyToEx(clszx_GroupTextEN objzx_GroupTextENS)
{
try
{
 clszx_GroupTextENEx objzx_GroupTextENT = new clszx_GroupTextENEx();
clszx_GroupTextBL.zx_GroupTextDA.CopyTo(objzx_GroupTextENS, objzx_GroupTextENT);
 return objzx_GroupTextENT;
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
public static List<clszx_GroupTextENEx> GetObjExLst(string strCondition)
{
List <clszx_GroupTextEN> arrObjLst = clszx_GroupTextBL.GetObjLst(strCondition);
List <clszx_GroupTextENEx> arrObjExLst = new List<clszx_GroupTextENEx>();
foreach (clszx_GroupTextEN objInFor in arrObjLst)
{
clszx_GroupTextENEx objzx_GroupTextENEx = new clszx_GroupTextENEx();
clszx_GroupTextBL.CopyTo(objInFor, objzx_GroupTextENEx);
arrObjExLst.Add(objzx_GroupTextENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strGroupTextId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_GroupTextENEx GetObjExByGroupTextId(string strGroupTextId)
{
clszx_GroupTextEN objzx_GroupTextEN = clszx_GroupTextBL.GetObjByGroupTextId(strGroupTextId);
clszx_GroupTextENEx objzx_GroupTextENEx = new clszx_GroupTextENEx();
clszx_GroupTextBL.CopyTo(objzx_GroupTextEN, objzx_GroupTextENEx);
return objzx_GroupTextENEx;
}
}
}