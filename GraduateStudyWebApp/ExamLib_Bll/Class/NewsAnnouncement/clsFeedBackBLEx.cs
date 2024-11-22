
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeedBackBLEx
 表名:FeedBack(01120279)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:52:16
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告
 模块英文名:NewsAnnouncement
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
public static class clsFeedBackBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objFeedBackENS">源对象</param>
 /// <returns>目标对象=>clsFeedBackEN:objFeedBackENT</returns>
 public static clsFeedBackENEx CopyToEx(this clsFeedBackEN objFeedBackENS)
{
try
{
 clsFeedBackENEx objFeedBackENT = new clsFeedBackENEx();
clsFeedBackBL.FeedBackDA.CopyTo(objFeedBackENS, objFeedBackENT);
 return objFeedBackENT;
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
 /// <param name = "objFeedBackENS">源对象</param>
 /// <returns>目标对象=>clsFeedBackEN:objFeedBackENT</returns>
 public static clsFeedBackEN CopyTo(this clsFeedBackENEx objFeedBackENS)
{
try
{
 clsFeedBackEN objFeedBackENT = new clsFeedBackEN();
clsFeedBackBL.CopyTo(objFeedBackENS, objFeedBackENT);
 return objFeedBackENT;
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
 /// 反馈意见(FeedBack)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsFeedBackBLEx : clsFeedBackBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsFeedBackDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsFeedBackDAEx FeedBackDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsFeedBackDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objFeedBackENS">源对象</param>
 /// <returns>目标对象=>clsFeedBackEN:objFeedBackENT</returns>
 public static clsFeedBackENEx CopyToEx(clsFeedBackEN objFeedBackENS)
{
try
{
 clsFeedBackENEx objFeedBackENT = new clsFeedBackENEx();
clsFeedBackBL.FeedBackDA.CopyTo(objFeedBackENS, objFeedBackENT);
 return objFeedBackENT;
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
public static List<clsFeedBackENEx> GetObjExLst(string strCondition)
{
List <clsFeedBackEN> arrObjLst = clsFeedBackBL.GetObjLst(strCondition);
List <clsFeedBackENEx> arrObjExLst = new List<clsFeedBackENEx>();
foreach (clsFeedBackEN objInFor in arrObjLst)
{
clsFeedBackENEx objFeedBackENEx = new clsFeedBackENEx();
clsFeedBackBL.CopyTo(objInFor, objFeedBackENEx);
arrObjExLst.Add(objFeedBackENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngFeedBackId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsFeedBackENEx GetObjExByFeedBackId(long lngFeedBackId)
{
clsFeedBackEN objFeedBackEN = clsFeedBackBL.GetObjByFeedBackId(lngFeedBackId);
clsFeedBackENEx objFeedBackENEx = new clsFeedBackENEx();
clsFeedBackBL.CopyTo(objFeedBackEN, objFeedBackENEx);
return objFeedBackENEx;
}
}
}