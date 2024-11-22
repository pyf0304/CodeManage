
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperStatusBLEx
 表名:gs_PaperStatus(01120676)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/12 21:48:34
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培参数
 模块英文名:ParameterTable
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
public static class clsgs_PaperStatusBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PaperStatusENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperStatusEN:objgs_PaperStatusENT</returns>
 public static clsgs_PaperStatusENEx CopyToEx(this clsgs_PaperStatusEN objgs_PaperStatusENS)
{
try
{
 clsgs_PaperStatusENEx objgs_PaperStatusENT = new clsgs_PaperStatusENEx();
clsgs_PaperStatusBL.gs_PaperStatusDA.CopyTo(objgs_PaperStatusENS, objgs_PaperStatusENT);
 return objgs_PaperStatusENT;
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
 /// <param name = "objgs_PaperStatusENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperStatusEN:objgs_PaperStatusENT</returns>
 public static clsgs_PaperStatusEN CopyTo(this clsgs_PaperStatusENEx objgs_PaperStatusENS)
{
try
{
 clsgs_PaperStatusEN objgs_PaperStatusENT = new clsgs_PaperStatusEN();
clsgs_PaperStatusBL.CopyTo(objgs_PaperStatusENS, objgs_PaperStatusENT);
 return objgs_PaperStatusENT;
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
 /// 论文状态表(gs_PaperStatus)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_PaperStatusBLEx : clsgs_PaperStatusBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_PaperStatusDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_PaperStatusDAEx gs_PaperStatusDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_PaperStatusDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PaperStatusENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperStatusEN:objgs_PaperStatusENT</returns>
 public static clsgs_PaperStatusENEx CopyToEx(clsgs_PaperStatusEN objgs_PaperStatusENS)
{
try
{
 clsgs_PaperStatusENEx objgs_PaperStatusENT = new clsgs_PaperStatusENEx();
clsgs_PaperStatusBL.gs_PaperStatusDA.CopyTo(objgs_PaperStatusENS, objgs_PaperStatusENT);
 return objgs_PaperStatusENT;
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
public static List<clsgs_PaperStatusENEx> GetObjExLst(string strCondition)
{
List <clsgs_PaperStatusEN> arrObjLst = clsgs_PaperStatusBL.GetObjLst(strCondition);
List <clsgs_PaperStatusENEx> arrObjExLst = new List<clsgs_PaperStatusENEx>();
foreach (clsgs_PaperStatusEN objInFor in arrObjLst)
{
clsgs_PaperStatusENEx objgs_PaperStatusENEx = new clsgs_PaperStatusENEx();
clsgs_PaperStatusBL.CopyTo(objInFor, objgs_PaperStatusENEx);
arrObjExLst.Add(objgs_PaperStatusENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strPaperStatusId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_PaperStatusENEx GetObjExByPaperStatusId(string strPaperStatusId)
{
clsgs_PaperStatusEN objgs_PaperStatusEN = clsgs_PaperStatusBL.GetObjByPaperStatusId(strPaperStatusId);
clsgs_PaperStatusENEx objgs_PaperStatusENEx = new clsgs_PaperStatusENEx();
clsgs_PaperStatusBL.CopyTo(objgs_PaperStatusEN, objgs_PaperStatusENEx);
return objgs_PaperStatusENEx;
}
}
}