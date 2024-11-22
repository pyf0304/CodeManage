
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TeachingDateBLEx
 表名:vzx_TeachingDate(01120857)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:56:25
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
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
public static class clsvzx_TeachingDateBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_TeachingDateENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TeachingDateEN:objvzx_TeachingDateENT</returns>
 public static clsvzx_TeachingDateENEx CopyToEx(this clsvzx_TeachingDateEN objvzx_TeachingDateENS)
{
try
{
 clsvzx_TeachingDateENEx objvzx_TeachingDateENT = new clsvzx_TeachingDateENEx();
clsvzx_TeachingDateBL.vzx_TeachingDateDA.CopyTo(objvzx_TeachingDateENS, objvzx_TeachingDateENT);
 return objvzx_TeachingDateENT;
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
 /// <param name = "objvzx_TeachingDateENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TeachingDateEN:objvzx_TeachingDateENT</returns>
 public static clsvzx_TeachingDateEN CopyTo(this clsvzx_TeachingDateENEx objvzx_TeachingDateENS)
{
try
{
 clsvzx_TeachingDateEN objvzx_TeachingDateENT = new clsvzx_TeachingDateEN();
clsvzx_TeachingDateBL.CopyTo(objvzx_TeachingDateENS, objvzx_TeachingDateENT);
 return objvzx_TeachingDateENT;
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
 /// vzx_TeachingDate(vzx_TeachingDate)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_TeachingDateBLEx : clsvzx_TeachingDateBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_TeachingDateDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_TeachingDateDAEx vzx_TeachingDateDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_TeachingDateDAEx();
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
public static List<clsvzx_TeachingDateENEx> GetObjExLst(string strCondition)
{
List <clsvzx_TeachingDateEN> arrObjLst = clsvzx_TeachingDateBL.GetObjLst(strCondition);
List <clsvzx_TeachingDateENEx> arrObjExLst = new List<clsvzx_TeachingDateENEx>();
foreach (clsvzx_TeachingDateEN objInFor in arrObjLst)
{
clsvzx_TeachingDateENEx objvzx_TeachingDateENEx = new clsvzx_TeachingDateENEx();
clsvzx_TeachingDateBL.CopyTo(objInFor, objvzx_TeachingDateENEx);
arrObjExLst.Add(objvzx_TeachingDateENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_TeachingDateENEx GetObjExBymId(long lngmId)
{
clsvzx_TeachingDateEN objvzx_TeachingDateEN = clsvzx_TeachingDateBL.GetObjBymId(lngmId);
clsvzx_TeachingDateENEx objvzx_TeachingDateENEx = new clsvzx_TeachingDateENEx();
clsvzx_TeachingDateBL.CopyTo(objvzx_TeachingDateEN, objvzx_TeachingDateENEx);
return objvzx_TeachingDateENEx;
}
}
}