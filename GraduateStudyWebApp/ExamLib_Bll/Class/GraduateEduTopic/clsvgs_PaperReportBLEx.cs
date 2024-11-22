
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperReportBLEx
 表名:vgs_PaperReport(01120771)
 生成代码版本:2020.11.22.1
 生成日期:2020/11/30 18:44:19
 生成者:yy
 生成服务器IP:192.168.1.10
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
public static class clsvgs_PaperReportBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_PaperReportENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PaperReportEN:objvgs_PaperReportENT</returns>
 public static clsvgs_PaperReportENEx CopyToEx(this clsvgs_PaperReportEN objvgs_PaperReportENS)
{
try
{
 clsvgs_PaperReportENEx objvgs_PaperReportENT = new clsvgs_PaperReportENEx();
clsvgs_PaperReportBL.vgs_PaperReportDA.CopyTo(objvgs_PaperReportENS, objvgs_PaperReportENT);
 return objvgs_PaperReportENT;
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
 /// <param name = "objvgs_PaperReportENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PaperReportEN:objvgs_PaperReportENT</returns>
 public static clsvgs_PaperReportEN CopyTo(this clsvgs_PaperReportENEx objvgs_PaperReportENS)
{
try
{
 clsvgs_PaperReportEN objvgs_PaperReportENT = new clsvgs_PaperReportEN();
clsvgs_PaperReportBL.CopyTo(objvgs_PaperReportENS, objvgs_PaperReportENT);
 return objvgs_PaperReportENT;
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
 /// 论文汇报视图(vgs_PaperReport)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_PaperReportBLEx : clsvgs_PaperReportBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_PaperReportDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_PaperReportDAEx vgs_PaperReportDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_PaperReportDAEx();
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
public static List<clsvgs_PaperReportENEx> GetObjExLst(string strCondition)
{
List <clsvgs_PaperReportEN> arrObjLst = clsvgs_PaperReportBL.GetObjLst(strCondition);
List <clsvgs_PaperReportENEx> arrObjExLst = new List<clsvgs_PaperReportENEx>();
foreach (clsvgs_PaperReportEN objInFor in arrObjLst)
{
clsvgs_PaperReportENEx objvgs_PaperReportENEx = new clsvgs_PaperReportENEx();
clsvgs_PaperReportBL.CopyTo(objInFor, objvgs_PaperReportENEx);
arrObjExLst.Add(objvgs_PaperReportENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strReportId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_PaperReportENEx GetObjExByReportId(string strReportId)
{
clsvgs_PaperReportEN objvgs_PaperReportEN = clsvgs_PaperReportBL.GetObjByReportId(strReportId);
clsvgs_PaperReportENEx objvgs_PaperReportENEx = new clsvgs_PaperReportENEx();
clsvgs_PaperReportBL.CopyTo(objvgs_PaperReportEN, objvgs_PaperReportENEx);
return objvgs_PaperReportENEx;
}
}
}