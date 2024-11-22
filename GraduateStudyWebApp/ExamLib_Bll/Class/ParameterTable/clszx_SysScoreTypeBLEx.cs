
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysScoreTypeBLEx
 表名:zx_SysScoreType(01120825)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:00:28
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
public static class clszx_SysScoreTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_SysScoreTypeEN:objzx_SysScoreTypeENT</returns>
 public static clszx_SysScoreTypeENEx CopyToEx(this clszx_SysScoreTypeEN objzx_SysScoreTypeENS)
{
try
{
 clszx_SysScoreTypeENEx objzx_SysScoreTypeENT = new clszx_SysScoreTypeENEx();
clszx_SysScoreTypeBL.zx_SysScoreTypeDA.CopyTo(objzx_SysScoreTypeENS, objzx_SysScoreTypeENT);
 return objzx_SysScoreTypeENT;
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
 /// <param name = "objzx_SysScoreTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_SysScoreTypeEN:objzx_SysScoreTypeENT</returns>
 public static clszx_SysScoreTypeEN CopyTo(this clszx_SysScoreTypeENEx objzx_SysScoreTypeENS)
{
try
{
 clszx_SysScoreTypeEN objzx_SysScoreTypeENT = new clszx_SysScoreTypeEN();
clszx_SysScoreTypeBL.CopyTo(objzx_SysScoreTypeENS, objzx_SysScoreTypeENT);
 return objzx_SysScoreTypeENT;
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
 /// 中学评分类型表(zx_SysScoreType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_SysScoreTypeBLEx : clszx_SysScoreTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_SysScoreTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_SysScoreTypeDAEx zx_SysScoreTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_SysScoreTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_SysScoreTypeEN:objzx_SysScoreTypeENT</returns>
 public static clszx_SysScoreTypeENEx CopyToEx(clszx_SysScoreTypeEN objzx_SysScoreTypeENS)
{
try
{
 clszx_SysScoreTypeENEx objzx_SysScoreTypeENT = new clszx_SysScoreTypeENEx();
clszx_SysScoreTypeBL.zx_SysScoreTypeDA.CopyTo(objzx_SysScoreTypeENS, objzx_SysScoreTypeENT);
 return objzx_SysScoreTypeENT;
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
public static List<clszx_SysScoreTypeENEx> GetObjExLst(string strCondition)
{
List <clszx_SysScoreTypeEN> arrObjLst = clszx_SysScoreTypeBL.GetObjLst(strCondition);
List <clszx_SysScoreTypeENEx> arrObjExLst = new List<clszx_SysScoreTypeENEx>();
foreach (clszx_SysScoreTypeEN objInFor in arrObjLst)
{
clszx_SysScoreTypeENEx objzx_SysScoreTypeENEx = new clszx_SysScoreTypeENEx();
clszx_SysScoreTypeBL.CopyTo(objInFor, objzx_SysScoreTypeENEx);
arrObjExLst.Add(objzx_SysScoreTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxScoreTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_SysScoreTypeENEx GetObjExByzxScoreTypeId(string strzxScoreTypeId)
{
clszx_SysScoreTypeEN objzx_SysScoreTypeEN = clszx_SysScoreTypeBL.GetObjByzxScoreTypeId(strzxScoreTypeId);
clszx_SysScoreTypeENEx objzx_SysScoreTypeENEx = new clszx_SysScoreTypeENEx();
clszx_SysScoreTypeBL.CopyTo(objzx_SysScoreTypeEN, objzx_SysScoreTypeENEx);
return objzx_SysScoreTypeENEx;
}
}
}