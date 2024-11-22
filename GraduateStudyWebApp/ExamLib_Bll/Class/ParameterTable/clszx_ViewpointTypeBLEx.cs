
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointTypeBLEx
 表名:zx_ViewpointType(01120828)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:01:41
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
public static class clszx_ViewpointTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ViewpointTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewpointTypeEN:objzx_ViewpointTypeENT</returns>
 public static clszx_ViewpointTypeENEx CopyToEx(this clszx_ViewpointTypeEN objzx_ViewpointTypeENS)
{
try
{
 clszx_ViewpointTypeENEx objzx_ViewpointTypeENT = new clszx_ViewpointTypeENEx();
clszx_ViewpointTypeBL.zx_ViewpointTypeDA.CopyTo(objzx_ViewpointTypeENS, objzx_ViewpointTypeENT);
 return objzx_ViewpointTypeENT;
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
 /// <param name = "objzx_ViewpointTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewpointTypeEN:objzx_ViewpointTypeENT</returns>
 public static clszx_ViewpointTypeEN CopyTo(this clszx_ViewpointTypeENEx objzx_ViewpointTypeENS)
{
try
{
 clszx_ViewpointTypeEN objzx_ViewpointTypeENT = new clszx_ViewpointTypeEN();
clszx_ViewpointTypeBL.CopyTo(objzx_ViewpointTypeENS, objzx_ViewpointTypeENT);
 return objzx_ViewpointTypeENT;
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
 /// 中学观点类型(zx_ViewpointType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_ViewpointTypeBLEx : clszx_ViewpointTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_ViewpointTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_ViewpointTypeDAEx zx_ViewpointTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_ViewpointTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ViewpointTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewpointTypeEN:objzx_ViewpointTypeENT</returns>
 public static clszx_ViewpointTypeENEx CopyToEx(clszx_ViewpointTypeEN objzx_ViewpointTypeENS)
{
try
{
 clszx_ViewpointTypeENEx objzx_ViewpointTypeENT = new clszx_ViewpointTypeENEx();
clszx_ViewpointTypeBL.zx_ViewpointTypeDA.CopyTo(objzx_ViewpointTypeENS, objzx_ViewpointTypeENT);
 return objzx_ViewpointTypeENT;
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
public static List<clszx_ViewpointTypeENEx> GetObjExLst(string strCondition)
{
List <clszx_ViewpointTypeEN> arrObjLst = clszx_ViewpointTypeBL.GetObjLst(strCondition);
List <clszx_ViewpointTypeENEx> arrObjExLst = new List<clszx_ViewpointTypeENEx>();
foreach (clszx_ViewpointTypeEN objInFor in arrObjLst)
{
clszx_ViewpointTypeENEx objzx_ViewpointTypeENEx = new clszx_ViewpointTypeENEx();
clszx_ViewpointTypeBL.CopyTo(objInFor, objzx_ViewpointTypeENEx);
arrObjExLst.Add(objzx_ViewpointTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxViewpointTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_ViewpointTypeENEx GetObjExByzxViewpointTypeId(string strzxViewpointTypeId)
{
clszx_ViewpointTypeEN objzx_ViewpointTypeEN = clszx_ViewpointTypeBL.GetObjByzxViewpointTypeId(strzxViewpointTypeId);
clszx_ViewpointTypeENEx objzx_ViewpointTypeENEx = new clszx_ViewpointTypeENEx();
clszx_ViewpointTypeBL.CopyTo(objzx_ViewpointTypeEN, objzx_ViewpointTypeENEx);
return objzx_ViewpointTypeENEx;
}
}
}