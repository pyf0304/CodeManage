
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_UserConfigBLEx
 表名:zx_UserConfig(01120829)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:55:20
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:考试管理
 模块英文名:ExamManage
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
public static class clszx_UserConfigBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_UserConfigENS">源对象</param>
 /// <returns>目标对象=>clszx_UserConfigEN:objzx_UserConfigENT</returns>
 public static clszx_UserConfigENEx CopyToEx(this clszx_UserConfigEN objzx_UserConfigENS)
{
try
{
 clszx_UserConfigENEx objzx_UserConfigENT = new clszx_UserConfigENEx();
clszx_UserConfigBL.zx_UserConfigDA.CopyTo(objzx_UserConfigENS, objzx_UserConfigENT);
 return objzx_UserConfigENT;
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
 /// <param name = "objzx_UserConfigENS">源对象</param>
 /// <returns>目标对象=>clszx_UserConfigEN:objzx_UserConfigENT</returns>
 public static clszx_UserConfigEN CopyTo(this clszx_UserConfigENEx objzx_UserConfigENS)
{
try
{
 clszx_UserConfigEN objzx_UserConfigENT = new clszx_UserConfigEN();
clszx_UserConfigBL.CopyTo(objzx_UserConfigENS, objzx_UserConfigENT);
 return objzx_UserConfigENT;
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
 /// 中学用户配置(zx_UserConfig)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_UserConfigBLEx : clszx_UserConfigBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_UserConfigDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_UserConfigDAEx zx_UserConfigDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_UserConfigDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_UserConfigENS">源对象</param>
 /// <returns>目标对象=>clszx_UserConfigEN:objzx_UserConfigENT</returns>
 public static clszx_UserConfigENEx CopyToEx(clszx_UserConfigEN objzx_UserConfigENS)
{
try
{
 clszx_UserConfigENEx objzx_UserConfigENT = new clszx_UserConfigENEx();
clszx_UserConfigBL.zx_UserConfigDA.CopyTo(objzx_UserConfigENS, objzx_UserConfigENT);
 return objzx_UserConfigENT;
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
public static List<clszx_UserConfigENEx> GetObjExLst(string strCondition)
{
List <clszx_UserConfigEN> arrObjLst = clszx_UserConfigBL.GetObjLst(strCondition);
List <clszx_UserConfigENEx> arrObjExLst = new List<clszx_UserConfigENEx>();
foreach (clszx_UserConfigEN objInFor in arrObjLst)
{
clszx_UserConfigENEx objzx_UserConfigENEx = new clszx_UserConfigENEx();
clszx_UserConfigBL.CopyTo(objInFor, objzx_UserConfigENEx);
arrObjExLst.Add(objzx_UserConfigENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngConfigId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_UserConfigENEx GetObjExByConfigId(long lngConfigId)
{
clszx_UserConfigEN objzx_UserConfigEN = clszx_UserConfigBL.GetObjByConfigId(lngConfigId);
clszx_UserConfigENEx objzx_UserConfigENEx = new clszx_UserConfigENEx();
clszx_UserConfigBL.CopyTo(objzx_UserConfigEN, objzx_UserConfigENEx);
return objzx_UserConfigENEx;
}
}
}