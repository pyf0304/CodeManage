
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_RequestNoticeBLEx
 表名:gs_RequestNotice(01120724)
 生成代码版本:2020.08.20.1
 生成日期:2020/08/31 16:19:09
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
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
public static class clsgs_RequestNoticeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_RequestNoticeENS">源对象</param>
 /// <returns>目标对象=>clsgs_RequestNoticeEN:objgs_RequestNoticeENT</returns>
 public static clsgs_RequestNoticeENEx CopyToEx(this clsgs_RequestNoticeEN objgs_RequestNoticeENS)
{
try
{
 clsgs_RequestNoticeENEx objgs_RequestNoticeENT = new clsgs_RequestNoticeENEx();
clsgs_RequestNoticeBL.gs_RequestNoticeDA.CopyTo(objgs_RequestNoticeENS, objgs_RequestNoticeENT);
 return objgs_RequestNoticeENT;
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
 /// <param name = "objgs_RequestNoticeENS">源对象</param>
 /// <returns>目标对象=>clsgs_RequestNoticeEN:objgs_RequestNoticeENT</returns>
 public static clsgs_RequestNoticeEN CopyTo(this clsgs_RequestNoticeENEx objgs_RequestNoticeENS)
{
try
{
 clsgs_RequestNoticeEN objgs_RequestNoticeENT = new clsgs_RequestNoticeEN();
clsgs_RequestNoticeBL.CopyTo(objgs_RequestNoticeENS, objgs_RequestNoticeENT);
 return objgs_RequestNoticeENT;
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
 /// 请求通知表(gs_RequestNotice)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_RequestNoticeBLEx : clsgs_RequestNoticeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_RequestNoticeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_RequestNoticeDAEx gs_RequestNoticeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_RequestNoticeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_RequestNoticeENS">源对象</param>
 /// <returns>目标对象=>clsgs_RequestNoticeEN:objgs_RequestNoticeENT</returns>
 public static clsgs_RequestNoticeENEx CopyToEx(clsgs_RequestNoticeEN objgs_RequestNoticeENS)
{
try
{
 clsgs_RequestNoticeENEx objgs_RequestNoticeENT = new clsgs_RequestNoticeENEx();
clsgs_RequestNoticeBL.gs_RequestNoticeDA.CopyTo(objgs_RequestNoticeENS, objgs_RequestNoticeENT);
 return objgs_RequestNoticeENT;
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
public static List<clsgs_RequestNoticeENEx> GetObjExLst(string strCondition)
{
List <clsgs_RequestNoticeEN> arrObjLst = clsgs_RequestNoticeBL.GetObjLst(strCondition);
List <clsgs_RequestNoticeENEx> arrObjExLst = new List<clsgs_RequestNoticeENEx>();
foreach (clsgs_RequestNoticeEN objInFor in arrObjLst)
{
clsgs_RequestNoticeENEx objgs_RequestNoticeENEx = new clsgs_RequestNoticeENEx();
clsgs_RequestNoticeBL.CopyTo(objInFor, objgs_RequestNoticeENEx);
arrObjExLst.Add(objgs_RequestNoticeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngRequestId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_RequestNoticeENEx GetObjExByRequestId(long lngRequestId)
{
clsgs_RequestNoticeEN objgs_RequestNoticeEN = clsgs_RequestNoticeBL.GetObjByRequestId(lngRequestId);
clsgs_RequestNoticeENEx objgs_RequestNoticeENEx = new clsgs_RequestNoticeENEx();
clsgs_RequestNoticeBL.CopyTo(objgs_RequestNoticeEN, objgs_RequestNoticeENEx);
return objgs_RequestNoticeENEx;
}
}
}