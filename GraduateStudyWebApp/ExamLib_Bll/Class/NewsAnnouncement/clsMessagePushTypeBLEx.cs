
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMessagePushTypeBLEx
 表名:MessagePushType(01120281)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:52:20
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
public static class clsMessagePushTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objMessagePushTypeENS">源对象</param>
 /// <returns>目标对象=>clsMessagePushTypeEN:objMessagePushTypeENT</returns>
 public static clsMessagePushTypeENEx CopyToEx(this clsMessagePushTypeEN objMessagePushTypeENS)
{
try
{
 clsMessagePushTypeENEx objMessagePushTypeENT = new clsMessagePushTypeENEx();
clsMessagePushTypeBL.MessagePushTypeDA.CopyTo(objMessagePushTypeENS, objMessagePushTypeENT);
 return objMessagePushTypeENT;
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
 /// <param name = "objMessagePushTypeENS">源对象</param>
 /// <returns>目标对象=>clsMessagePushTypeEN:objMessagePushTypeENT</returns>
 public static clsMessagePushTypeEN CopyTo(this clsMessagePushTypeENEx objMessagePushTypeENS)
{
try
{
 clsMessagePushTypeEN objMessagePushTypeENT = new clsMessagePushTypeEN();
clsMessagePushTypeBL.CopyTo(objMessagePushTypeENS, objMessagePushTypeENT);
 return objMessagePushTypeENT;
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
 /// 消息类型(MessagePushType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsMessagePushTypeBLEx : clsMessagePushTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsMessagePushTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsMessagePushTypeDAEx MessagePushTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsMessagePushTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objMessagePushTypeENS">源对象</param>
 /// <returns>目标对象=>clsMessagePushTypeEN:objMessagePushTypeENT</returns>
 public static clsMessagePushTypeENEx CopyToEx(clsMessagePushTypeEN objMessagePushTypeENS)
{
try
{
 clsMessagePushTypeENEx objMessagePushTypeENT = new clsMessagePushTypeENEx();
clsMessagePushTypeBL.MessagePushTypeDA.CopyTo(objMessagePushTypeENS, objMessagePushTypeENT);
 return objMessagePushTypeENT;
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
public static List<clsMessagePushTypeENEx> GetObjExLst(string strCondition)
{
List <clsMessagePushTypeEN> arrObjLst = clsMessagePushTypeBL.GetObjLst(strCondition);
List <clsMessagePushTypeENEx> arrObjExLst = new List<clsMessagePushTypeENEx>();
foreach (clsMessagePushTypeEN objInFor in arrObjLst)
{
clsMessagePushTypeENEx objMessagePushTypeENEx = new clsMessagePushTypeENEx();
clsMessagePushTypeBL.CopyTo(objInFor, objMessagePushTypeENEx);
arrObjExLst.Add(objMessagePushTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strMessageTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsMessagePushTypeENEx GetObjExByMessageTypeId(string strMessageTypeId)
{
clsMessagePushTypeEN objMessagePushTypeEN = clsMessagePushTypeBL.GetObjByMessageTypeId(strMessageTypeId);
clsMessagePushTypeENEx objMessagePushTypeENEx = new clsMessagePushTypeENEx();
clsMessagePushTypeBL.CopyTo(objMessagePushTypeEN, objMessagePushTypeENEx);
return objMessagePushTypeENEx;
}
}
}