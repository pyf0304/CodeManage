
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDiscipline_psBLEx
 表名:Discipline_ps(01120100)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 12:12:43
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


namespace ExamLib.BusinessLogicEx
{
public static class clsDiscipline_psBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objDiscipline_psENS">源对象</param>
 /// <returns>目标对象=>clsDiscipline_psEN:objDiscipline_psENT</returns>
 public static clsDiscipline_psENEx CopyToEx(this clsDiscipline_psEN objDiscipline_psENS)
{
try
{
 clsDiscipline_psENEx objDiscipline_psENT = new clsDiscipline_psENEx();
clsDiscipline_psBL.Discipline_psDA.CopyTo(objDiscipline_psENS, objDiscipline_psENT);
 return objDiscipline_psENT;
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
 /// <param name = "objDiscipline_psENS">源对象</param>
 /// <returns>目标对象=>clsDiscipline_psEN:objDiscipline_psENT</returns>
 public static clsDiscipline_psEN CopyTo(this clsDiscipline_psENEx objDiscipline_psENS)
{
try
{
 clsDiscipline_psEN objDiscipline_psENT = new clsDiscipline_psEN();
clsDiscipline_psBL.CopyTo(objDiscipline_psENS, objDiscipline_psENT);
 return objDiscipline_psENT;
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
 /// 学科_ps(Discipline_ps)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsDiscipline_psBLEx : clsDiscipline_psBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsDiscipline_psDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsDiscipline_psDAEx Discipline_psDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsDiscipline_psDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objDiscipline_psENS">源对象</param>
 /// <returns>目标对象=>clsDiscipline_psEN:objDiscipline_psENT</returns>
 public static clsDiscipline_psENEx CopyToEx(clsDiscipline_psEN objDiscipline_psENS)
{
try
{
 clsDiscipline_psENEx objDiscipline_psENT = new clsDiscipline_psENEx();
clsDiscipline_psBL.Discipline_psDA.CopyTo(objDiscipline_psENS, objDiscipline_psENT);
 return objDiscipline_psENT;
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
public static List<clsDiscipline_psENEx> GetObjExLst(string strCondition)
{
List <clsDiscipline_psEN> arrObjLst = clsDiscipline_psBL.GetObjLst(strCondition);
List <clsDiscipline_psENEx> arrObjExLst = new List<clsDiscipline_psENEx>();
foreach (clsDiscipline_psEN objInFor in arrObjLst)
{
clsDiscipline_psENEx objDiscipline_psENEx = new clsDiscipline_psENEx();
clsDiscipline_psBL.CopyTo(objInFor, objDiscipline_psENEx);
arrObjExLst.Add(objDiscipline_psENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_Discipline_Ps">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsDiscipline_psENEx GetObjExByid_Discipline_Ps(string strid_Discipline_Ps)
{
clsDiscipline_psEN objDiscipline_psEN = clsDiscipline_psBL.GetObjByIdDisciplinePs(strid_Discipline_Ps);
clsDiscipline_psENEx objDiscipline_psENEx = new clsDiscipline_psENEx();
clsDiscipline_psBL.CopyTo(objDiscipline_psEN, objDiscipline_psENEx);
return objDiscipline_psENEx;
}
}
}