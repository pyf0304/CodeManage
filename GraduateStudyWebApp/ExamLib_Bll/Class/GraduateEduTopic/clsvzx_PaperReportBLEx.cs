
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_PaperReportBLEx
 表名:vzx_PaperReport(01120832)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:00:15
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题
 模块英文名:GraduateEduTopic
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
public static class clsvzx_PaperReportBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_PaperReportENS">源对象</param>
 /// <returns>目标对象=>clsvzx_PaperReportEN:objvzx_PaperReportENT</returns>
 public static clsvzx_PaperReportENEx CopyToEx(this clsvzx_PaperReportEN objvzx_PaperReportENS)
{
try
{
 clsvzx_PaperReportENEx objvzx_PaperReportENT = new clsvzx_PaperReportENEx();
clsvzx_PaperReportBL.vzx_PaperReportDA.CopyTo(objvzx_PaperReportENS, objvzx_PaperReportENT);
 return objvzx_PaperReportENT;
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
 /// <param name = "objvzx_PaperReportENS">源对象</param>
 /// <returns>目标对象=>clsvzx_PaperReportEN:objvzx_PaperReportENT</returns>
 public static clsvzx_PaperReportEN CopyTo(this clsvzx_PaperReportENEx objvzx_PaperReportENS)
{
try
{
 clsvzx_PaperReportEN objvzx_PaperReportENT = new clsvzx_PaperReportEN();
clsvzx_PaperReportBL.CopyTo(objvzx_PaperReportENS, objvzx_PaperReportENT);
 return objvzx_PaperReportENT;
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
 /// vzx_PaperReport(vzx_PaperReport)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_PaperReportBLEx : clsvzx_PaperReportBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_PaperReportDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_PaperReportDAEx vzx_PaperReportDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_PaperReportDAEx();
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
public static List<clsvzx_PaperReportENEx> GetObjExLst(string strCondition)
{
List <clsvzx_PaperReportEN> arrObjLst = clsvzx_PaperReportBL.GetObjLst(strCondition);
List <clsvzx_PaperReportENEx> arrObjExLst = new List<clsvzx_PaperReportENEx>();
foreach (clsvzx_PaperReportEN objInFor in arrObjLst)
{
clsvzx_PaperReportENEx objvzx_PaperReportENEx = new clsvzx_PaperReportENEx();
clsvzx_PaperReportBL.CopyTo(objInFor, objvzx_PaperReportENEx);
arrObjExLst.Add(objvzx_PaperReportENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxReportId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_PaperReportENEx GetObjExByzxReportId(string strzxReportId)
{
clsvzx_PaperReportEN objvzx_PaperReportEN = clsvzx_PaperReportBL.GetObjByzxReportId(strzxReportId);
clsvzx_PaperReportENEx objvzx_PaperReportENEx = new clsvzx_PaperReportENEx();
clsvzx_PaperReportBL.CopyTo(objvzx_PaperReportEN, objvzx_PaperReportENEx);
return objvzx_PaperReportENEx;
}
}
}