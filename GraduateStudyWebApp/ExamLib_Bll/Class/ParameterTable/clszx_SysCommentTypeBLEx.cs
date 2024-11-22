﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysCommentTypeBLEx
 表名:zx_SysCommentType(01120796)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:58:34
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
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
public static class clszx_SysCommentTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SysCommentTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_SysCommentTypeEN:objzx_SysCommentTypeENT</returns>
 public static clszx_SysCommentTypeENEx CopyToEx(this clszx_SysCommentTypeEN objzx_SysCommentTypeENS)
{
try
{
 clszx_SysCommentTypeENEx objzx_SysCommentTypeENT = new clszx_SysCommentTypeENEx();
clszx_SysCommentTypeBL.zx_SysCommentTypeDA.CopyTo(objzx_SysCommentTypeENS, objzx_SysCommentTypeENT);
 return objzx_SysCommentTypeENT;
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
 /// <param name = "objzx_SysCommentTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_SysCommentTypeEN:objzx_SysCommentTypeENT</returns>
 public static clszx_SysCommentTypeEN CopyTo(this clszx_SysCommentTypeENEx objzx_SysCommentTypeENS)
{
try
{
 clszx_SysCommentTypeEN objzx_SysCommentTypeENT = new clszx_SysCommentTypeEN();
clszx_SysCommentTypeBL.CopyTo(objzx_SysCommentTypeENS, objzx_SysCommentTypeENT);
 return objzx_SysCommentTypeENT;
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
 /// 中学评论类型表(zx_SysCommentType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_SysCommentTypeBLEx : clszx_SysCommentTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_SysCommentTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_SysCommentTypeDAEx zx_SysCommentTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_SysCommentTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SysCommentTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_SysCommentTypeEN:objzx_SysCommentTypeENT</returns>
 public static clszx_SysCommentTypeENEx CopyToEx(clszx_SysCommentTypeEN objzx_SysCommentTypeENS)
{
try
{
 clszx_SysCommentTypeENEx objzx_SysCommentTypeENT = new clszx_SysCommentTypeENEx();
clszx_SysCommentTypeBL.zx_SysCommentTypeDA.CopyTo(objzx_SysCommentTypeENS, objzx_SysCommentTypeENT);
 return objzx_SysCommentTypeENT;
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
public static List<clszx_SysCommentTypeENEx> GetObjExLst(string strCondition)
{
List <clszx_SysCommentTypeEN> arrObjLst = clszx_SysCommentTypeBL.GetObjLst(strCondition);
List <clszx_SysCommentTypeENEx> arrObjExLst = new List<clszx_SysCommentTypeENEx>();
foreach (clszx_SysCommentTypeEN objInFor in arrObjLst)
{
clszx_SysCommentTypeENEx objzx_SysCommentTypeENEx = new clszx_SysCommentTypeENEx();
clszx_SysCommentTypeBL.CopyTo(objInFor, objzx_SysCommentTypeENEx);
arrObjExLst.Add(objzx_SysCommentTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxCommentTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_SysCommentTypeENEx GetObjExByzxCommentTypeId(string strzxCommentTypeId)
{
clszx_SysCommentTypeEN objzx_SysCommentTypeEN = clszx_SysCommentTypeBL.GetObjByzxCommentTypeId(strzxCommentTypeId);
clszx_SysCommentTypeENEx objzx_SysCommentTypeENEx = new clszx_SysCommentTypeENEx();
clszx_SysCommentTypeBL.CopyTo(objzx_SysCommentTypeEN, objzx_SysCommentTypeENEx);
return objzx_SysCommentTypeENEx;
}
}
}