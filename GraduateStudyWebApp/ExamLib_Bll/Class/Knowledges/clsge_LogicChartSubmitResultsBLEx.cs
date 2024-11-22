
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_LogicChartSubmitResultsBLEx
 表名:ge_LogicChartSubmitResults(01120912)
 生成代码版本:2021.03.30.1
 生成日期:2021/04/03 19:00:59
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsge_LogicChartSubmitResultsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsENS">源对象</param>
 /// <returns>目标对象=>clsge_LogicChartSubmitResultsEN:objge_LogicChartSubmitResultsENT</returns>
 public static clsge_LogicChartSubmitResultsENEx CopyToEx(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsENS)
{
try
{
 clsge_LogicChartSubmitResultsENEx objge_LogicChartSubmitResultsENT = new clsge_LogicChartSubmitResultsENEx();
clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.CopyTo(objge_LogicChartSubmitResultsENS, objge_LogicChartSubmitResultsENT);
 return objge_LogicChartSubmitResultsENT;
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
 /// <param name = "objge_LogicChartSubmitResultsENS">源对象</param>
 /// <returns>目标对象=>clsge_LogicChartSubmitResultsEN:objge_LogicChartSubmitResultsENT</returns>
 public static clsge_LogicChartSubmitResultsEN CopyTo(this clsge_LogicChartSubmitResultsENEx objge_LogicChartSubmitResultsENS)
{
try
{
 clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsENT = new clsge_LogicChartSubmitResultsEN();
clsge_LogicChartSubmitResultsBL.CopyTo(objge_LogicChartSubmitResultsENS, objge_LogicChartSubmitResultsENT);
 return objge_LogicChartSubmitResultsENT;
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
 /// 知识逻辑图提交结果(ge_LogicChartSubmitResults)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsge_LogicChartSubmitResultsBLEx : clsge_LogicChartSubmitResultsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsge_LogicChartSubmitResultsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsge_LogicChartSubmitResultsDAEx ge_LogicChartSubmitResultsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsge_LogicChartSubmitResultsDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsENS">源对象</param>
 /// <returns>目标对象=>clsge_LogicChartSubmitResultsEN:objge_LogicChartSubmitResultsENT</returns>
 public static clsge_LogicChartSubmitResultsENEx CopyToEx(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsENS)
{
try
{
 clsge_LogicChartSubmitResultsENEx objge_LogicChartSubmitResultsENT = new clsge_LogicChartSubmitResultsENEx();
clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.CopyTo(objge_LogicChartSubmitResultsENS, objge_LogicChartSubmitResultsENT);
 return objge_LogicChartSubmitResultsENT;
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
public static List<clsge_LogicChartSubmitResultsENEx> GetObjExLst(string strCondition)
{
List <clsge_LogicChartSubmitResultsEN> arrObjLst = clsge_LogicChartSubmitResultsBL.GetObjLst(strCondition);
List <clsge_LogicChartSubmitResultsENEx> arrObjExLst = new List<clsge_LogicChartSubmitResultsENEx>();
foreach (clsge_LogicChartSubmitResultsEN objInFor in arrObjLst)
{
clsge_LogicChartSubmitResultsENEx objge_LogicChartSubmitResultsENEx = new clsge_LogicChartSubmitResultsENEx();
clsge_LogicChartSubmitResultsBL.CopyTo(objInFor, objge_LogicChartSubmitResultsENEx);
arrObjExLst.Add(objge_LogicChartSubmitResultsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsge_LogicChartSubmitResultsENEx GetObjExBymId(long lngmId)
{
clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = clsge_LogicChartSubmitResultsBL.GetObjBymId(lngmId);
clsge_LogicChartSubmitResultsENEx objge_LogicChartSubmitResultsENEx = new clsge_LogicChartSubmitResultsENEx();
clsge_LogicChartSubmitResultsBL.CopyTo(objge_LogicChartSubmitResultsEN, objge_LogicChartSubmitResultsENEx);
return objge_LogicChartSubmitResultsENEx;
}
}
}