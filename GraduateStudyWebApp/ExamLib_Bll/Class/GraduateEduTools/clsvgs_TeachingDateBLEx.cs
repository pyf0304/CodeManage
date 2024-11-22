
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_TeachingDateBLEx
 表名:vgs_TeachingDate(01120687)
 生成代码版本:2020.06.27.2
 生成日期:2020/07/01 16:11:05
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培设置
 模块英文名:GraduateEduTools
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
public static class clsvgs_TeachingDateBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_TeachingDateENS">源对象</param>
 /// <returns>目标对象=>clsvgs_TeachingDateEN:objvgs_TeachingDateENT</returns>
 public static clsvgs_TeachingDateENEx CopyToEx(this clsvgs_TeachingDateEN objvgs_TeachingDateENS)
{
try
{
 clsvgs_TeachingDateENEx objvgs_TeachingDateENT = new clsvgs_TeachingDateENEx();
clsvgs_TeachingDateBL.vgs_TeachingDateDA.CopyTo(objvgs_TeachingDateENS, objvgs_TeachingDateENT);
 return objvgs_TeachingDateENT;
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
 /// <param name = "objvgs_TeachingDateENS">源对象</param>
 /// <returns>目标对象=>clsvgs_TeachingDateEN:objvgs_TeachingDateENT</returns>
 public static clsvgs_TeachingDateEN CopyTo(this clsvgs_TeachingDateENEx objvgs_TeachingDateENS)
{
try
{
 clsvgs_TeachingDateEN objvgs_TeachingDateENT = new clsvgs_TeachingDateEN();
clsvgs_TeachingDateBL.CopyTo(objvgs_TeachingDateENS, objvgs_TeachingDateENT);
 return objvgs_TeachingDateENT;
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
 /// vgs_TeachingDate(vgs_TeachingDate)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_TeachingDateBLEx : clsvgs_TeachingDateBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_TeachingDateDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_TeachingDateDAEx vgs_TeachingDateDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_TeachingDateDAEx();
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
public static List<clsvgs_TeachingDateENEx> GetObjExLst(string strCondition)
{
List <clsvgs_TeachingDateEN> arrObjLst = clsvgs_TeachingDateBL.GetObjLst(strCondition);
List <clsvgs_TeachingDateENEx> arrObjExLst = new List<clsvgs_TeachingDateENEx>();
foreach (clsvgs_TeachingDateEN objInFor in arrObjLst)
{
clsvgs_TeachingDateENEx objvgs_TeachingDateENEx = new clsvgs_TeachingDateENEx();
clsvgs_TeachingDateBL.CopyTo(objInFor, objvgs_TeachingDateENEx);
arrObjExLst.Add(objvgs_TeachingDateENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_TeachingDateENEx GetObjExBymId(long lngmId)
{
clsvgs_TeachingDateEN objvgs_TeachingDateEN = clsvgs_TeachingDateBL.GetObjBymId(lngmId);
clsvgs_TeachingDateENEx objvgs_TeachingDateENEx = new clsvgs_TeachingDateENEx();
clsvgs_TeachingDateBL.CopyTo(objvgs_TeachingDateEN, objvgs_TeachingDateENEx);
return objvgs_TeachingDateENEx;
}
}
}