
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_InspectionResultsBLEx
 表名:ge_InspectionResults(01120897)
 生成代码版本:2021.03.13.1
 生成日期:2021/03/16 16:58:40
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习
 模块英文名:GameLearn
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
public static class clsge_InspectionResultsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objge_InspectionResultsENS">源对象</param>
 /// <returns>目标对象=>clsge_InspectionResultsEN:objge_InspectionResultsENT</returns>
 public static clsge_InspectionResultsENEx CopyToEx(this clsge_InspectionResultsEN objge_InspectionResultsENS)
{
try
{
 clsge_InspectionResultsENEx objge_InspectionResultsENT = new clsge_InspectionResultsENEx();
clsge_InspectionResultsBL.ge_InspectionResultsDA.CopyTo(objge_InspectionResultsENS, objge_InspectionResultsENT);
 return objge_InspectionResultsENT;
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
 /// <param name = "objge_InspectionResultsENS">源对象</param>
 /// <returns>目标对象=>clsge_InspectionResultsEN:objge_InspectionResultsENT</returns>
 public static clsge_InspectionResultsEN CopyTo(this clsge_InspectionResultsENEx objge_InspectionResultsENS)
{
try
{
 clsge_InspectionResultsEN objge_InspectionResultsENT = new clsge_InspectionResultsEN();
clsge_InspectionResultsBL.CopyTo(objge_InspectionResultsENS, objge_InspectionResultsENT);
 return objge_InspectionResultsENT;
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
 /// 编程检查结果表(ge_InspectionResults)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsge_InspectionResultsBLEx : clsge_InspectionResultsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsge_InspectionResultsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsge_InspectionResultsDAEx ge_InspectionResultsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsge_InspectionResultsDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objge_InspectionResultsENS">源对象</param>
 /// <returns>目标对象=>clsge_InspectionResultsEN:objge_InspectionResultsENT</returns>
 public static clsge_InspectionResultsENEx CopyToEx(clsge_InspectionResultsEN objge_InspectionResultsENS)
{
try
{
 clsge_InspectionResultsENEx objge_InspectionResultsENT = new clsge_InspectionResultsENEx();
clsge_InspectionResultsBL.ge_InspectionResultsDA.CopyTo(objge_InspectionResultsENS, objge_InspectionResultsENT);
 return objge_InspectionResultsENT;
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
public static List<clsge_InspectionResultsENEx> GetObjExLst(string strCondition)
{
List <clsge_InspectionResultsEN> arrObjLst = clsge_InspectionResultsBL.GetObjLst(strCondition);
List <clsge_InspectionResultsENEx> arrObjExLst = new List<clsge_InspectionResultsENEx>();
foreach (clsge_InspectionResultsEN objInFor in arrObjLst)
{
clsge_InspectionResultsENEx objge_InspectionResultsENEx = new clsge_InspectionResultsENEx();
clsge_InspectionResultsBL.CopyTo(objInFor, objge_InspectionResultsENEx);
arrObjExLst.Add(objge_InspectionResultsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsge_InspectionResultsENEx GetObjExBymId(long lngmId)
{
clsge_InspectionResultsEN objge_InspectionResultsEN = clsge_InspectionResultsBL.GetObjBymId(lngmId);
clsge_InspectionResultsENEx objge_InspectionResultsENEx = new clsge_InspectionResultsENEx();
clsge_InspectionResultsBL.CopyTo(objge_InspectionResultsEN, objge_InspectionResultsENEx);
return objge_InspectionResultsENEx;
}
}
}