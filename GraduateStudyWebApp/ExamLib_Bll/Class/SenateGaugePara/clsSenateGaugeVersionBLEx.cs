
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeVersionBLEx
 表名:SenateGaugeVersion(01120297)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 17:34:36
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数
 模块英文名:SenateGaugePara
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
public static class clsSenateGaugeVersionBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objSenateGaugeVersionENS">源对象</param>
 /// <returns>目标对象=>clsSenateGaugeVersionEN:objSenateGaugeVersionENT</returns>
 public static clsSenateGaugeVersionENEx CopyToEx(this clsSenateGaugeVersionEN objSenateGaugeVersionENS)
{
try
{
 clsSenateGaugeVersionENEx objSenateGaugeVersionENT = new clsSenateGaugeVersionENEx();
clsSenateGaugeVersionBL.SenateGaugeVersionDA.CopyTo(objSenateGaugeVersionENS, objSenateGaugeVersionENT);
 return objSenateGaugeVersionENT;
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
 /// <param name = "objSenateGaugeVersionENS">源对象</param>
 /// <returns>目标对象=>clsSenateGaugeVersionEN:objSenateGaugeVersionENT</returns>
 public static clsSenateGaugeVersionEN CopyTo(this clsSenateGaugeVersionENEx objSenateGaugeVersionENS)
{
try
{
 clsSenateGaugeVersionEN objSenateGaugeVersionENT = new clsSenateGaugeVersionEN();
clsSenateGaugeVersionBL.CopyTo(objSenateGaugeVersionENS, objSenateGaugeVersionENT);
 return objSenateGaugeVersionENT;
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
 /// 评价量规版本(SenateGaugeVersion)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsSenateGaugeVersionBLEx : clsSenateGaugeVersionBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsSenateGaugeVersionDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsSenateGaugeVersionDAEx SenateGaugeVersionDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsSenateGaugeVersionDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objSenateGaugeVersionENS">源对象</param>
 /// <returns>目标对象=>clsSenateGaugeVersionEN:objSenateGaugeVersionENT</returns>
 public static clsSenateGaugeVersionENEx CopyToEx(clsSenateGaugeVersionEN objSenateGaugeVersionENS)
{
try
{
 clsSenateGaugeVersionENEx objSenateGaugeVersionENT = new clsSenateGaugeVersionENEx();
clsSenateGaugeVersionBL.SenateGaugeVersionDA.CopyTo(objSenateGaugeVersionENS, objSenateGaugeVersionENT);
 return objSenateGaugeVersionENT;
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
public static List<clsSenateGaugeVersionENEx> GetObjExLst(string strCondition)
{
List <clsSenateGaugeVersionEN> arrObjLst = clsSenateGaugeVersionBL.GetObjLst(strCondition);
List <clsSenateGaugeVersionENEx> arrObjExLst = new List<clsSenateGaugeVersionENEx>();
foreach (clsSenateGaugeVersionEN objInFor in arrObjLst)
{
clsSenateGaugeVersionENEx objSenateGaugeVersionENEx = new clsSenateGaugeVersionENEx();
clsSenateGaugeVersionBL.CopyTo(objInFor, objSenateGaugeVersionENEx);
arrObjExLst.Add(objSenateGaugeVersionENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_SenateGaugeVersion">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsSenateGaugeVersionENEx GetObjExByid_SenateGaugeVersion(string strid_SenateGaugeVersion)
{
clsSenateGaugeVersionEN objSenateGaugeVersionEN = clsSenateGaugeVersionBL.GetObjByIdSenateGaugeVersion(strid_SenateGaugeVersion);
clsSenateGaugeVersionENEx objSenateGaugeVersionENEx = new clsSenateGaugeVersionENEx();
clsSenateGaugeVersionBL.CopyTo(objSenateGaugeVersionEN, objSenateGaugeVersionENEx);
return objSenateGaugeVersionENEx;
}
}
}