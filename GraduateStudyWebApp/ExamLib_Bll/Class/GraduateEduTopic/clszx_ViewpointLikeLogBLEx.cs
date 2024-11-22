
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointLikeLogBLEx
 表名:zx_ViewpointLikeLog(01120858)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:58:01
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
public static class clszx_ViewpointLikeLogBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewpointLikeLogEN:objzx_ViewpointLikeLogENT</returns>
 public static clszx_ViewpointLikeLogENEx CopyToEx(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogENS)
{
try
{
 clszx_ViewpointLikeLogENEx objzx_ViewpointLikeLogENT = new clszx_ViewpointLikeLogENEx();
clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.CopyTo(objzx_ViewpointLikeLogENS, objzx_ViewpointLikeLogENT);
 return objzx_ViewpointLikeLogENT;
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
 /// <param name = "objzx_ViewpointLikeLogENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewpointLikeLogEN:objzx_ViewpointLikeLogENT</returns>
 public static clszx_ViewpointLikeLogEN CopyTo(this clszx_ViewpointLikeLogENEx objzx_ViewpointLikeLogENS)
{
try
{
 clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogENT = new clszx_ViewpointLikeLogEN();
clszx_ViewpointLikeLogBL.CopyTo(objzx_ViewpointLikeLogENS, objzx_ViewpointLikeLogENT);
 return objzx_ViewpointLikeLogENT;
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
 /// 中学观点点赞表(zx_ViewpointLikeLog)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_ViewpointLikeLogBLEx : clszx_ViewpointLikeLogBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_ViewpointLikeLogDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_ViewpointLikeLogDAEx zx_ViewpointLikeLogDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_ViewpointLikeLogDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewpointLikeLogEN:objzx_ViewpointLikeLogENT</returns>
 public static clszx_ViewpointLikeLogENEx CopyToEx(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogENS)
{
try
{
 clszx_ViewpointLikeLogENEx objzx_ViewpointLikeLogENT = new clszx_ViewpointLikeLogENEx();
clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.CopyTo(objzx_ViewpointLikeLogENS, objzx_ViewpointLikeLogENT);
 return objzx_ViewpointLikeLogENT;
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
public static List<clszx_ViewpointLikeLogENEx> GetObjExLst(string strCondition)
{
List <clszx_ViewpointLikeLogEN> arrObjLst = clszx_ViewpointLikeLogBL.GetObjLst(strCondition);
List <clszx_ViewpointLikeLogENEx> arrObjExLst = new List<clszx_ViewpointLikeLogENEx>();
foreach (clszx_ViewpointLikeLogEN objInFor in arrObjLst)
{
clszx_ViewpointLikeLogENEx objzx_ViewpointLikeLogENEx = new clszx_ViewpointLikeLogENEx();
clszx_ViewpointLikeLogBL.CopyTo(objInFor, objzx_ViewpointLikeLogENEx);
arrObjExLst.Add(objzx_ViewpointLikeLogENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngViewpointLikeLogId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_ViewpointLikeLogENEx GetObjExByViewpointLikeLogId(long lngViewpointLikeLogId)
{
clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = clszx_ViewpointLikeLogBL.GetObjByViewpointLikeLogId(lngViewpointLikeLogId);
clszx_ViewpointLikeLogENEx objzx_ViewpointLikeLogENEx = new clszx_ViewpointLikeLogENEx();
clszx_ViewpointLikeLogBL.CopyTo(objzx_ViewpointLikeLogEN, objzx_ViewpointLikeLogENEx);
return objzx_ViewpointLikeLogENEx;
}
}
}