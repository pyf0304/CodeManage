﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsNewsBLEx
 表名:News(00050478)
 生成代码版本:2019.07.15.2
 生成日期:2019/07/18 01:17:03
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置
 模块英文名:SystemSet
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


using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;
using AGC.BusinessLogic;


namespace AGC.BusinessLogicEx
{
public static class clsNewsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objNewsENS">源对象</param>
 /// <returns>目标对象=>clsNewsEN:objNewsENT</returns>
 public static clsNewsENEx CopyToEx(this clsNewsEN objNewsENS)
{
try
{
 clsNewsENEx objNewsENT = new clsNewsENEx();
clsNewsBL.CopyTo(objNewsENS, objNewsENT);
 return objNewsENT;
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
 /// <param name = "objNewsENS">源对象</param>
 /// <returns>目标对象=>clsNewsEN:objNewsENT</returns>
 public static clsNewsEN CopyTo(this clsNewsENEx objNewsENS)
{
try
{
 clsNewsEN objNewsENT = new clsNewsEN();
clsNewsBL.CopyTo(objNewsENS, objNewsENT);
 return objNewsENT;
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
 /// 信息内容表(News)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsNewsBLEx : clsNewsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsNewsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsNewsDAEx NewsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsNewsDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
/// </summary>
/// <param name="lngId_News">表关键字</param>
/// <returns></returns>
public new static bool DelRecordEx(long lngId_News)
{
clsSpecSQLforSql objSQL = null;
//获取连接对象
objSQL = clsNewsDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[News]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conNews.Id_News,
//lngId_News);
//        clsNewsBL.DelNewssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsNewsBL.DelRecord(lngId_News, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsNewsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
objException.Message,
lngId_News, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsNewsENEx> GetObjExLst(string strCondition)
{
List <clsNewsEN> arrObjLst = clsNewsBL.GetObjLst(strCondition);
List <clsNewsENEx> arrObjExLst = new List<clsNewsENEx>();
foreach (clsNewsEN objInFor in arrObjLst)
{
clsNewsENEx objNewsENEx = new clsNewsENEx();
clsNewsBL.CopyTo(objInFor, objNewsENEx);
arrObjExLst.Add(objNewsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngId_News">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsNewsENEx GetObjExById_News(long lngId_News)
{
clsNewsEN objNewsEN = clsNewsBL.GetObjById_News(lngId_News);
clsNewsENEx objNewsENEx = new clsNewsENEx();
clsNewsBL.CopyTo(objNewsEN, objNewsENEx);
return objNewsENEx;
}
}
}