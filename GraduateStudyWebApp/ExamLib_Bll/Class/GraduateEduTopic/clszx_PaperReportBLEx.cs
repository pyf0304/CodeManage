
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_PaperReportBLEx
 表名:zx_PaperReport(01120801)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:00:12
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
public static class clszx_PaperReportBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_PaperReportENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperReportEN:objzx_PaperReportENT</returns>
 public static clszx_PaperReportENEx CopyToEx(this clszx_PaperReportEN objzx_PaperReportENS)
{
try
{
 clszx_PaperReportENEx objzx_PaperReportENT = new clszx_PaperReportENEx();
clszx_PaperReportBL.zx_PaperReportDA.CopyTo(objzx_PaperReportENS, objzx_PaperReportENT);
 return objzx_PaperReportENT;
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
 /// <param name = "objzx_PaperReportENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperReportEN:objzx_PaperReportENT</returns>
 public static clszx_PaperReportEN CopyTo(this clszx_PaperReportENEx objzx_PaperReportENS)
{
try
{
 clszx_PaperReportEN objzx_PaperReportENT = new clszx_PaperReportEN();
clszx_PaperReportBL.CopyTo(objzx_PaperReportENS, objzx_PaperReportENT);
 return objzx_PaperReportENT;
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
 /// 中学论文汇报表(zx_PaperReport)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_PaperReportBLEx : clszx_PaperReportBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_PaperReportDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_PaperReportDAEx zx_PaperReportDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_PaperReportDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_PaperReportENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperReportEN:objzx_PaperReportENT</returns>
 public static clszx_PaperReportENEx CopyToEx(clszx_PaperReportEN objzx_PaperReportENS)
{
try
{
 clszx_PaperReportENEx objzx_PaperReportENT = new clszx_PaperReportENEx();
clszx_PaperReportBL.zx_PaperReportDA.CopyTo(objzx_PaperReportENS, objzx_PaperReportENT);
 return objzx_PaperReportENT;
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
public static List<clszx_PaperReportENEx> GetObjExLst(string strCondition)
{
List <clszx_PaperReportEN> arrObjLst = clszx_PaperReportBL.GetObjLst(strCondition);
List <clszx_PaperReportENEx> arrObjExLst = new List<clszx_PaperReportENEx>();
foreach (clszx_PaperReportEN objInFor in arrObjLst)
{
clszx_PaperReportENEx objzx_PaperReportENEx = new clszx_PaperReportENEx();
clszx_PaperReportBL.CopyTo(objInFor, objzx_PaperReportENEx);
arrObjExLst.Add(objzx_PaperReportENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxReportId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_PaperReportENEx GetObjExByzxReportId(string strzxReportId)
{
clszx_PaperReportEN objzx_PaperReportEN = clszx_PaperReportBL.GetObjByzxReportId(strzxReportId);
clszx_PaperReportENEx objzx_PaperReportENEx = new clszx_PaperReportENEx();
clszx_PaperReportBL.CopyTo(objzx_PaperReportEN, objzx_PaperReportENEx);
return objzx_PaperReportENEx;
}
}
}