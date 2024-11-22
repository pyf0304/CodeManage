
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysScoreWeightBLEx
 表名:SysScoreWeight(01120629)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:55:28
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置
 模块英文名:GraduateEduTools
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
public static class clsSysScoreWeightBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objSysScoreWeightENS">源对象</param>
 /// <returns>目标对象=>clsSysScoreWeightEN:objSysScoreWeightENT</returns>
 public static clsSysScoreWeightENEx CopyToEx(this clsSysScoreWeightEN objSysScoreWeightENS)
{
try
{
 clsSysScoreWeightENEx objSysScoreWeightENT = new clsSysScoreWeightENEx();
clsSysScoreWeightBL.SysScoreWeightDA.CopyTo(objSysScoreWeightENS, objSysScoreWeightENT);
 return objSysScoreWeightENT;
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
 /// <param name = "objSysScoreWeightENS">源对象</param>
 /// <returns>目标对象=>clsSysScoreWeightEN:objSysScoreWeightENT</returns>
 public static clsSysScoreWeightEN CopyTo(this clsSysScoreWeightENEx objSysScoreWeightENS)
{
try
{
 clsSysScoreWeightEN objSysScoreWeightENT = new clsSysScoreWeightEN();
clsSysScoreWeightBL.CopyTo(objSysScoreWeightENS, objSysScoreWeightENT);
 return objSysScoreWeightENT;
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
 /// 系统分数权重表(SysScoreWeight)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsSysScoreWeightBLEx : clsSysScoreWeightBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsSysScoreWeightDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsSysScoreWeightDAEx SysScoreWeightDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsSysScoreWeightDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objSysScoreWeightENS">源对象</param>
 /// <returns>目标对象=>clsSysScoreWeightEN:objSysScoreWeightENT</returns>
 public static clsSysScoreWeightENEx CopyToEx(clsSysScoreWeightEN objSysScoreWeightENS)
{
try
{
 clsSysScoreWeightENEx objSysScoreWeightENT = new clsSysScoreWeightENEx();
clsSysScoreWeightBL.SysScoreWeightDA.CopyTo(objSysScoreWeightENS, objSysScoreWeightENT);
 return objSysScoreWeightENT;
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
public static List<clsSysScoreWeightENEx> GetObjExLst(string strCondition)
{
List <clsSysScoreWeightEN> arrObjLst = clsSysScoreWeightBL.GetObjLst(strCondition);
List <clsSysScoreWeightENEx> arrObjExLst = new List<clsSysScoreWeightENEx>();
foreach (clsSysScoreWeightEN objInFor in arrObjLst)
{
clsSysScoreWeightENEx objSysScoreWeightENEx = new clsSysScoreWeightENEx();
clsSysScoreWeightBL.CopyTo(objInFor, objSysScoreWeightENEx);
arrObjExLst.Add(objSysScoreWeightENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strScoreWeightId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsSysScoreWeightENEx GetObjExByScoreWeightId(string strScoreWeightId)
{
clsSysScoreWeightEN objSysScoreWeightEN = clsSysScoreWeightBL.GetObjByScoreWeightId(strScoreWeightId);
clsSysScoreWeightENEx objSysScoreWeightENEx = new clsSysScoreWeightENEx();
clsSysScoreWeightBL.CopyTo(objSysScoreWeightEN, objSysScoreWeightENEx);
return objSysScoreWeightENEx;
}
}
}