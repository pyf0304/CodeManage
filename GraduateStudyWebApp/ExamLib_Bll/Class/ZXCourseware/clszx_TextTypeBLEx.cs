﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextTypeBLEx
 表名:zx_TextType(01120711)
 生成代码版本:2020.07.31.1
 生成日期:2020/07/31 22:47:37
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:中学生课件管理
 模块英文名:ZXCourseware
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
public static class clszx_TextTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TextTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_TextTypeEN:objzx_TextTypeENT</returns>
 public static clszx_TextTypeENEx CopyToEx(this clszx_TextTypeEN objzx_TextTypeENS)
{
try
{
 clszx_TextTypeENEx objzx_TextTypeENT = new clszx_TextTypeENEx();
clszx_TextTypeBL.zx_TextTypeDA.CopyTo(objzx_TextTypeENS, objzx_TextTypeENT);
 return objzx_TextTypeENT;
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
 /// <param name = "objzx_TextTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_TextTypeEN:objzx_TextTypeENT</returns>
 public static clszx_TextTypeEN CopyTo(this clszx_TextTypeENEx objzx_TextTypeENS)
{
try
{
 clszx_TextTypeEN objzx_TextTypeENT = new clszx_TextTypeEN();
clszx_TextTypeBL.CopyTo(objzx_TextTypeENS, objzx_TextTypeENT);
 return objzx_TextTypeENT;
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
 /// 中学课件类型(zx_TextType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_TextTypeBLEx : clszx_TextTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_TextTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_TextTypeDAEx zx_TextTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_TextTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TextTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_TextTypeEN:objzx_TextTypeENT</returns>
 public static clszx_TextTypeENEx CopyToEx(clszx_TextTypeEN objzx_TextTypeENS)
{
try
{
 clszx_TextTypeENEx objzx_TextTypeENT = new clszx_TextTypeENEx();
clszx_TextTypeBL.zx_TextTypeDA.CopyTo(objzx_TextTypeENS, objzx_TextTypeENT);
 return objzx_TextTypeENT;
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
public static List<clszx_TextTypeENEx> GetObjExLst(string strCondition)
{
List <clszx_TextTypeEN> arrObjLst = clszx_TextTypeBL.GetObjLst(strCondition);
List <clszx_TextTypeENEx> arrObjExLst = new List<clszx_TextTypeENEx>();
foreach (clszx_TextTypeEN objInFor in arrObjLst)
{
clszx_TextTypeENEx objzx_TextTypeENEx = new clszx_TextTypeENEx();
clszx_TextTypeBL.CopyTo(objInFor, objzx_TextTypeENEx);
arrObjExLst.Add(objzx_TextTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTextTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_TextTypeENEx GetObjExByTextTypeId(string strTextTypeId)
{
clszx_TextTypeEN objzx_TextTypeEN = clszx_TextTypeBL.GetObjByTextTypeId(strTextTypeId);
clszx_TextTypeENEx objzx_TextTypeENEx = new clszx_TextTypeENEx();
clszx_TextTypeBL.CopyTo(objzx_TextTypeEN, objzx_TextTypeENEx);
return objzx_TextTypeENEx;
}
}
}