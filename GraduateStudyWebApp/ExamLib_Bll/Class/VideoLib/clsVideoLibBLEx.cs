
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoLibBLEx
 表名:VideoLib(01120261)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/17 00:05:56
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库
 模块英文名:VideoLib
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
public static class clsVideoLibBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objVideoLibENS">源对象</param>
 /// <returns>目标对象=>clsVideoLibEN:objVideoLibENT</returns>
 public static clsVideoLibENEx CopyToEx(this clsVideoLibEN objVideoLibENS)
{
try
{
 clsVideoLibENEx objVideoLibENT = new clsVideoLibENEx();
clsVideoLibBL.VideoLibDA.CopyTo(objVideoLibENS, objVideoLibENT);
 return objVideoLibENT;
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
 /// <param name = "objVideoLibENS">源对象</param>
 /// <returns>目标对象=>clsVideoLibEN:objVideoLibENT</returns>
 public static clsVideoLibEN CopyTo(this clsVideoLibENEx objVideoLibENS)
{
try
{
 clsVideoLibEN objVideoLibENT = new clsVideoLibEN();
clsVideoLibBL.CopyTo(objVideoLibENS, objVideoLibENT);
 return objVideoLibENT;
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
 /// 视频库(VideoLib)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsVideoLibBLEx : clsVideoLibBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsVideoLibDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsVideoLibDAEx VideoLibDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsVideoLibDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objVideoLibENS">源对象</param>
 /// <returns>目标对象=>clsVideoLibEN:objVideoLibENT</returns>
 public static clsVideoLibENEx CopyToEx(clsVideoLibEN objVideoLibENS)
{
try
{
 clsVideoLibENEx objVideoLibENT = new clsVideoLibENEx();
clsVideoLibBL.VideoLibDA.CopyTo(objVideoLibENS, objVideoLibENT);
 return objVideoLibENT;
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
public static List<clsVideoLibENEx> GetObjExLst(string strCondition)
{
List <clsVideoLibEN> arrObjLst = clsVideoLibBL.GetObjLst(strCondition);
List <clsVideoLibENEx> arrObjExLst = new List<clsVideoLibENEx>();
foreach (clsVideoLibEN objInFor in arrObjLst)
{
clsVideoLibENEx objVideoLibENEx = new clsVideoLibENEx();
clsVideoLibBL.CopyTo(objInFor, objVideoLibENEx);
arrObjExLst.Add(objVideoLibENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strId_VideoLib">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsVideoLibENEx GetObjExById_VideoLib(string strId_VideoLib)
{
clsVideoLibEN objVideoLibEN = clsVideoLibBL.GetObjByIdVideoLib(strId_VideoLib);
clsVideoLibENEx objVideoLibENEx = new clsVideoLibENEx();
clsVideoLibBL.CopyTo(objVideoLibEN, objVideoLibENEx);
return objVideoLibENEx;
}
}
}