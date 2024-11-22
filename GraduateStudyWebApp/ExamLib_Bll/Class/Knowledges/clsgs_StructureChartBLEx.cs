
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_StructureChartBLEx
 表名:gs_StructureChart(01120878)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/05 01:02:45
 生成者:lyl
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
public static class clsgs_StructureChartBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_StructureChartENS">源对象</param>
 /// <returns>目标对象=>clsgs_StructureChartEN:objgs_StructureChartENT</returns>
 public static clsgs_StructureChartENEx CopyToEx(this clsgs_StructureChartEN objgs_StructureChartENS)
{
try
{
 clsgs_StructureChartENEx objgs_StructureChartENT = new clsgs_StructureChartENEx();
clsgs_StructureChartBL.gs_StructureChartDA.CopyTo(objgs_StructureChartENS, objgs_StructureChartENT);
 return objgs_StructureChartENT;
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
 /// <param name = "objgs_StructureChartENS">源对象</param>
 /// <returns>目标对象=>clsgs_StructureChartEN:objgs_StructureChartENT</returns>
 public static clsgs_StructureChartEN CopyTo(this clsgs_StructureChartENEx objgs_StructureChartENS)
{
try
{
 clsgs_StructureChartEN objgs_StructureChartENT = new clsgs_StructureChartEN();
clsgs_StructureChartBL.CopyTo(objgs_StructureChartENS, objgs_StructureChartENT);
 return objgs_StructureChartENT;
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
 /// 结构图表(gs_StructureChart)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_StructureChartBLEx : clsgs_StructureChartBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_StructureChartDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_StructureChartDAEx gs_StructureChartDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_StructureChartDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_StructureChartENS">源对象</param>
 /// <returns>目标对象=>clsgs_StructureChartEN:objgs_StructureChartENT</returns>
 public static clsgs_StructureChartENEx CopyToEx(clsgs_StructureChartEN objgs_StructureChartENS)
{
try
{
 clsgs_StructureChartENEx objgs_StructureChartENT = new clsgs_StructureChartENEx();
clsgs_StructureChartBL.gs_StructureChartDA.CopyTo(objgs_StructureChartENS, objgs_StructureChartENT);
 return objgs_StructureChartENT;
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
public static List<clsgs_StructureChartENEx> GetObjExLst(string strCondition)
{
List <clsgs_StructureChartEN> arrObjLst = clsgs_StructureChartBL.GetObjLst(strCondition);
List <clsgs_StructureChartENEx> arrObjExLst = new List<clsgs_StructureChartENEx>();
foreach (clsgs_StructureChartEN objInFor in arrObjLst)
{
clsgs_StructureChartENEx objgs_StructureChartENEx = new clsgs_StructureChartENEx();
clsgs_StructureChartBL.CopyTo(objInFor, objgs_StructureChartENEx);
arrObjExLst.Add(objgs_StructureChartENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strStructureChartId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_StructureChartENEx GetObjExByStructureChartId(string strStructureChartId)
{
clsgs_StructureChartEN objgs_StructureChartEN = clsgs_StructureChartBL.GetObjByStructureChartId(strStructureChartId);
clsgs_StructureChartENEx objgs_StructureChartENEx = new clsgs_StructureChartENEx();
clsgs_StructureChartBL.CopyTo(objgs_StructureChartEN, objgs_StructureChartENEx);
return objgs_StructureChartENEx;
}
}
}