
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicTaskStatusBLEx
 表名:zx_TopicTaskStatus(01120823)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:01:00
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
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
public static class clszx_TopicTaskStatusBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TopicTaskStatusENS">源对象</param>
 /// <returns>目标对象=>clszx_TopicTaskStatusEN:objzx_TopicTaskStatusENT</returns>
 public static clszx_TopicTaskStatusENEx CopyToEx(this clszx_TopicTaskStatusEN objzx_TopicTaskStatusENS)
{
try
{
 clszx_TopicTaskStatusENEx objzx_TopicTaskStatusENT = new clszx_TopicTaskStatusENEx();
clszx_TopicTaskStatusBL.zx_TopicTaskStatusDA.CopyTo(objzx_TopicTaskStatusENS, objzx_TopicTaskStatusENT);
 return objzx_TopicTaskStatusENT;
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
 /// <param name = "objzx_TopicTaskStatusENS">源对象</param>
 /// <returns>目标对象=>clszx_TopicTaskStatusEN:objzx_TopicTaskStatusENT</returns>
 public static clszx_TopicTaskStatusEN CopyTo(this clszx_TopicTaskStatusENEx objzx_TopicTaskStatusENS)
{
try
{
 clszx_TopicTaskStatusEN objzx_TopicTaskStatusENT = new clszx_TopicTaskStatusEN();
clszx_TopicTaskStatusBL.CopyTo(objzx_TopicTaskStatusENS, objzx_TopicTaskStatusENT);
 return objzx_TopicTaskStatusENT;
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
 /// 中学主题任务状态(zx_TopicTaskStatus)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_TopicTaskStatusBLEx : clszx_TopicTaskStatusBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_TopicTaskStatusDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_TopicTaskStatusDAEx zx_TopicTaskStatusDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_TopicTaskStatusDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TopicTaskStatusENS">源对象</param>
 /// <returns>目标对象=>clszx_TopicTaskStatusEN:objzx_TopicTaskStatusENT</returns>
 public static clszx_TopicTaskStatusENEx CopyToEx(clszx_TopicTaskStatusEN objzx_TopicTaskStatusENS)
{
try
{
 clszx_TopicTaskStatusENEx objzx_TopicTaskStatusENT = new clszx_TopicTaskStatusENEx();
clszx_TopicTaskStatusBL.zx_TopicTaskStatusDA.CopyTo(objzx_TopicTaskStatusENS, objzx_TopicTaskStatusENT);
 return objzx_TopicTaskStatusENT;
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
public static List<clszx_TopicTaskStatusENEx> GetObjExLst(string strCondition)
{
List <clszx_TopicTaskStatusEN> arrObjLst = clszx_TopicTaskStatusBL.GetObjLst(strCondition);
List <clszx_TopicTaskStatusENEx> arrObjExLst = new List<clszx_TopicTaskStatusENEx>();
foreach (clszx_TopicTaskStatusEN objInFor in arrObjLst)
{
clszx_TopicTaskStatusENEx objzx_TopicTaskStatusENEx = new clszx_TopicTaskStatusENEx();
clszx_TopicTaskStatusBL.CopyTo(objInFor, objzx_TopicTaskStatusENEx);
arrObjExLst.Add(objzx_TopicTaskStatusENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxStatusId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_TopicTaskStatusENEx GetObjExByzxStatusId(string strzxStatusId)
{
clszx_TopicTaskStatusEN objzx_TopicTaskStatusEN = clszx_TopicTaskStatusBL.GetObjByzxStatusId(strzxStatusId);
clszx_TopicTaskStatusENEx objzx_TopicTaskStatusENEx = new clszx_TopicTaskStatusENEx();
clszx_TopicTaskStatusBL.CopyTo(objzx_TopicTaskStatusEN, objzx_TopicTaskStatusENEx);
return objzx_TopicTaskStatusENEx;
}
}
}