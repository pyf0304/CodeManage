
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKcWkStatusBLEx
 表名:KcWkStatus(01120573)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 17:29:40
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理
 模块英文名:CourseManage
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
public static class clsKcWkStatusBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objKcWkStatusENS">源对象</param>
 /// <returns>目标对象=>clsKcWkStatusEN:objKcWkStatusENT</returns>
 public static clsKcWkStatusENEx CopyToEx(this clsKcWkStatusEN objKcWkStatusENS)
{
try
{
 clsKcWkStatusENEx objKcWkStatusENT = new clsKcWkStatusENEx();
clsKcWkStatusBL.KcWkStatusDA.CopyTo(objKcWkStatusENS, objKcWkStatusENT);
 return objKcWkStatusENT;
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
 /// <param name = "objKcWkStatusENS">源对象</param>
 /// <returns>目标对象=>clsKcWkStatusEN:objKcWkStatusENT</returns>
 public static clsKcWkStatusEN CopyTo(this clsKcWkStatusENEx objKcWkStatusENS)
{
try
{
 clsKcWkStatusEN objKcWkStatusENT = new clsKcWkStatusEN();
clsKcWkStatusBL.CopyTo(objKcWkStatusENS, objKcWkStatusENT);
 return objKcWkStatusENT;
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
 /// 课程单双全周状态(KcWkStatus)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsKcWkStatusBLEx : clsKcWkStatusBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsKcWkStatusDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsKcWkStatusDAEx KcWkStatusDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsKcWkStatusDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objKcWkStatusENS">源对象</param>
 /// <returns>目标对象=>clsKcWkStatusEN:objKcWkStatusENT</returns>
 public static clsKcWkStatusENEx CopyToEx(clsKcWkStatusEN objKcWkStatusENS)
{
try
{
 clsKcWkStatusENEx objKcWkStatusENT = new clsKcWkStatusENEx();
clsKcWkStatusBL.KcWkStatusDA.CopyTo(objKcWkStatusENS, objKcWkStatusENT);
 return objKcWkStatusENT;
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
public static List<clsKcWkStatusENEx> GetObjExLst(string strCondition)
{
List <clsKcWkStatusEN> arrObjLst = clsKcWkStatusBL.GetObjLst(strCondition);
List <clsKcWkStatusENEx> arrObjExLst = new List<clsKcWkStatusENEx>();
foreach (clsKcWkStatusEN objInFor in arrObjLst)
{
clsKcWkStatusENEx objKcWkStatusENEx = new clsKcWkStatusENEx();
clsKcWkStatusBL.CopyTo(objInFor, objKcWkStatusENEx);
arrObjExLst.Add(objKcWkStatusENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strWeekStatusID">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsKcWkStatusENEx GetObjExByWeekStatusID(string strWeekStatusID)
{
clsKcWkStatusEN objKcWkStatusEN = clsKcWkStatusBL.GetObjByWeekStatusId(strWeekStatusID);
clsKcWkStatusENEx objKcWkStatusENEx = new clsKcWkStatusENEx();
clsKcWkStatusBL.CopyTo(objKcWkStatusEN, objKcWkStatusENEx);
return objKcWkStatusENEx;
}
}
}