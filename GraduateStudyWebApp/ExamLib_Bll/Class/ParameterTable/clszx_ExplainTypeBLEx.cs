
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ExplainTypeBLEx
 表名:zx_ExplainType(01120815)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:59:03
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
public static class clszx_ExplainTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ExplainTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_ExplainTypeEN:objzx_ExplainTypeENT</returns>
 public static clszx_ExplainTypeENEx CopyToEx(this clszx_ExplainTypeEN objzx_ExplainTypeENS)
{
try
{
 clszx_ExplainTypeENEx objzx_ExplainTypeENT = new clszx_ExplainTypeENEx();
clszx_ExplainTypeBL.zx_ExplainTypeDA.CopyTo(objzx_ExplainTypeENS, objzx_ExplainTypeENT);
 return objzx_ExplainTypeENT;
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
 /// <param name = "objzx_ExplainTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_ExplainTypeEN:objzx_ExplainTypeENT</returns>
 public static clszx_ExplainTypeEN CopyTo(this clszx_ExplainTypeENEx objzx_ExplainTypeENS)
{
try
{
 clszx_ExplainTypeEN objzx_ExplainTypeENT = new clszx_ExplainTypeEN();
clszx_ExplainTypeBL.CopyTo(objzx_ExplainTypeENS, objzx_ExplainTypeENT);
 return objzx_ExplainTypeENT;
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
 /// 中学说明类型(zx_ExplainType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_ExplainTypeBLEx : clszx_ExplainTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_ExplainTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_ExplainTypeDAEx zx_ExplainTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_ExplainTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ExplainTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_ExplainTypeEN:objzx_ExplainTypeENT</returns>
 public static clszx_ExplainTypeENEx CopyToEx(clszx_ExplainTypeEN objzx_ExplainTypeENS)
{
try
{
 clszx_ExplainTypeENEx objzx_ExplainTypeENT = new clszx_ExplainTypeENEx();
clszx_ExplainTypeBL.zx_ExplainTypeDA.CopyTo(objzx_ExplainTypeENS, objzx_ExplainTypeENT);
 return objzx_ExplainTypeENT;
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
public static List<clszx_ExplainTypeENEx> GetObjExLst(string strCondition)
{
List <clszx_ExplainTypeEN> arrObjLst = clszx_ExplainTypeBL.GetObjLst(strCondition);
List <clszx_ExplainTypeENEx> arrObjExLst = new List<clszx_ExplainTypeENEx>();
foreach (clszx_ExplainTypeEN objInFor in arrObjLst)
{
clszx_ExplainTypeENEx objzx_ExplainTypeENEx = new clszx_ExplainTypeENEx();
clszx_ExplainTypeBL.CopyTo(objInFor, objzx_ExplainTypeENEx);
arrObjExLst.Add(objzx_ExplainTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxExplainTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_ExplainTypeENEx GetObjExByzxExplainTypeId(string strzxExplainTypeId)
{
clszx_ExplainTypeEN objzx_ExplainTypeEN = clszx_ExplainTypeBL.GetObjByzxExplainTypeId(strzxExplainTypeId);
clszx_ExplainTypeENEx objzx_ExplainTypeENEx = new clszx_ExplainTypeENEx();
clszx_ExplainTypeBL.CopyTo(objzx_ExplainTypeEN, objzx_ExplainTypeENEx);
return objzx_ExplainTypeENEx;
}
}
}