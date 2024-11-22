
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDiscipline4TeaBLEx
 表名:Discipline4Tea(01120517)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 12:12:15
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
using ExamLib.Const;

namespace ExamLib.BusinessLogicEx
{
public static class clsDiscipline4TeaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objDiscipline4TeaENS">源对象</param>
 /// <returns>目标对象=>clsDiscipline4TeaEN:objDiscipline4TeaENT</returns>
 public static clsDiscipline4TeaENEx CopyToEx(this clsDiscipline4TeaEN objDiscipline4TeaENS)
{
try
{
 clsDiscipline4TeaENEx objDiscipline4TeaENT = new clsDiscipline4TeaENEx();
clsDiscipline4TeaBL.Discipline4TeaDA.CopyTo(objDiscipline4TeaENS, objDiscipline4TeaENT);
 return objDiscipline4TeaENT;
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
 /// <param name = "objDiscipline4TeaENS">源对象</param>
 /// <returns>目标对象=>clsDiscipline4TeaEN:objDiscipline4TeaENT</returns>
 public static clsDiscipline4TeaEN CopyTo(this clsDiscipline4TeaENEx objDiscipline4TeaENS)
{
try
{
 clsDiscipline4TeaEN objDiscipline4TeaENT = new clsDiscipline4TeaEN();
clsDiscipline4TeaBL.CopyTo(objDiscipline4TeaENS, objDiscipline4TeaENT);
 return objDiscipline4TeaENT;
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
 /// 学科表4Tea(Discipline4Tea)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsDiscipline4TeaBLEx : clsDiscipline4TeaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsDiscipline4TeaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsDiscipline4TeaDAEx Discipline4TeaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsDiscipline4TeaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objDiscipline4TeaENS">源对象</param>
 /// <returns>目标对象=>clsDiscipline4TeaEN:objDiscipline4TeaENT</returns>
 public static clsDiscipline4TeaENEx CopyToEx(clsDiscipline4TeaEN objDiscipline4TeaENS)
{
try
{
 clsDiscipline4TeaENEx objDiscipline4TeaENT = new clsDiscipline4TeaENEx();
clsDiscipline4TeaBL.Discipline4TeaDA.CopyTo(objDiscipline4TeaENS, objDiscipline4TeaENT);
 return objDiscipline4TeaENT;
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
public static List<clsDiscipline4TeaENEx> GetObjExLst(string strCondition)
{
List <clsDiscipline4TeaEN> arrObjLst = clsDiscipline4TeaBL.GetObjLst(strCondition);
List <clsDiscipline4TeaENEx> arrObjExLst = new List<clsDiscipline4TeaENEx>();
foreach (clsDiscipline4TeaEN objInFor in arrObjLst)
{
clsDiscipline4TeaENEx objDiscipline4TeaENEx = new clsDiscipline4TeaENEx();
clsDiscipline4TeaBL.CopyTo(objInFor, objDiscipline4TeaENEx);
arrObjExLst.Add(objDiscipline4TeaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_Discipline">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsDiscipline4TeaENEx GetObjExByid_Discipline(string strid_Discipline)
{
clsDiscipline4TeaEN objDiscipline4TeaEN = clsDiscipline4TeaBL.GetObjByid_Discipline(strid_Discipline);
clsDiscipline4TeaENEx objDiscipline4TeaENEx = new clsDiscipline4TeaENEx();
clsDiscipline4TeaBL.CopyTo(objDiscipline4TeaEN, objDiscipline4TeaENEx);
return objDiscipline4TeaENEx;
}
}
}