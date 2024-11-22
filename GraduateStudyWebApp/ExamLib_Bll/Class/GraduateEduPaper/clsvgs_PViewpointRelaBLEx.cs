﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PViewpointRelaBLEx
 表名:vgs_PViewpointRela(01120669)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/12 23:27:41
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
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
public static class clsvgs_PViewpointRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PViewpointRelaEN:objvgs_PViewpointRelaENT</returns>
 public static clsvgs_PViewpointRelaENEx CopyToEx(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaENS)
{
try
{
 clsvgs_PViewpointRelaENEx objvgs_PViewpointRelaENT = new clsvgs_PViewpointRelaENEx();
clsvgs_PViewpointRelaBL.vgs_PViewpointRelaDA.CopyTo(objvgs_PViewpointRelaENS, objvgs_PViewpointRelaENT);
 return objvgs_PViewpointRelaENT;
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
 /// <param name = "objvgs_PViewpointRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PViewpointRelaEN:objvgs_PViewpointRelaENT</returns>
 public static clsvgs_PViewpointRelaEN CopyTo(this clsvgs_PViewpointRelaENEx objvgs_PViewpointRelaENS)
{
try
{
 clsvgs_PViewpointRelaEN objvgs_PViewpointRelaENT = new clsvgs_PViewpointRelaEN();
clsvgs_PViewpointRelaBL.CopyTo(objvgs_PViewpointRelaENS, objvgs_PViewpointRelaENT);
 return objvgs_PViewpointRelaENT;
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
 /// 论文观点关系视图(vgs_PViewpointRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_PViewpointRelaBLEx : clsvgs_PViewpointRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_PViewpointRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_PViewpointRelaDAEx vgs_PViewpointRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_PViewpointRelaDAEx();
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
public static List<clsvgs_PViewpointRelaENEx> GetObjExLst(string strCondition)
{
List <clsvgs_PViewpointRelaEN> arrObjLst = clsvgs_PViewpointRelaBL.GetObjLst(strCondition);
List <clsvgs_PViewpointRelaENEx> arrObjExLst = new List<clsvgs_PViewpointRelaENEx>();
foreach (clsvgs_PViewpointRelaEN objInFor in arrObjLst)
{
clsvgs_PViewpointRelaENEx objvgs_PViewpointRelaENEx = new clsvgs_PViewpointRelaENEx();
clsvgs_PViewpointRelaBL.CopyTo(objInFor, objvgs_PViewpointRelaENEx);
arrObjExLst.Add(objvgs_PViewpointRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_PViewpointRelaENEx GetObjExBymId(long lngmId)
{
clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = clsvgs_PViewpointRelaBL.GetObjBymId(lngmId);
clsvgs_PViewpointRelaENEx objvgs_PViewpointRelaENEx = new clsvgs_PViewpointRelaENEx();
clsvgs_PViewpointRelaBL.CopyTo(objvgs_PViewpointRelaEN, objvgs_PViewpointRelaENEx);
return objvgs_PViewpointRelaENEx;
}
}
}