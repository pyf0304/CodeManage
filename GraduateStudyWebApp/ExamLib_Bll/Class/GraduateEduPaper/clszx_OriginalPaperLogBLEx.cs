
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_OriginalPaperLogBLEx
 表名:zx_OriginalPaperLog(01120782)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:56:43
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
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
public static class clszx_OriginalPaperLogBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_OriginalPaperLogENS">源对象</param>
 /// <returns>目标对象=>clszx_OriginalPaperLogEN:objzx_OriginalPaperLogENT</returns>
 public static clszx_OriginalPaperLogENEx CopyToEx(this clszx_OriginalPaperLogEN objzx_OriginalPaperLogENS)
{
try
{
 clszx_OriginalPaperLogENEx objzx_OriginalPaperLogENT = new clszx_OriginalPaperLogENEx();
clszx_OriginalPaperLogBL.zx_OriginalPaperLogDA.CopyTo(objzx_OriginalPaperLogENS, objzx_OriginalPaperLogENT);
 return objzx_OriginalPaperLogENT;
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
 /// <param name = "objzx_OriginalPaperLogENS">源对象</param>
 /// <returns>目标对象=>clszx_OriginalPaperLogEN:objzx_OriginalPaperLogENT</returns>
 public static clszx_OriginalPaperLogEN CopyTo(this clszx_OriginalPaperLogENEx objzx_OriginalPaperLogENS)
{
try
{
 clszx_OriginalPaperLogEN objzx_OriginalPaperLogENT = new clszx_OriginalPaperLogEN();
clszx_OriginalPaperLogBL.CopyTo(objzx_OriginalPaperLogENS, objzx_OriginalPaperLogENT);
 return objzx_OriginalPaperLogENT;
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
 /// 作文日志表(zx_OriginalPaperLog)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_OriginalPaperLogBLEx : clszx_OriginalPaperLogBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_OriginalPaperLogDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_OriginalPaperLogDAEx zx_OriginalPaperLogDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_OriginalPaperLogDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_OriginalPaperLogENS">源对象</param>
 /// <returns>目标对象=>clszx_OriginalPaperLogEN:objzx_OriginalPaperLogENT</returns>
 public static clszx_OriginalPaperLogENEx CopyToEx(clszx_OriginalPaperLogEN objzx_OriginalPaperLogENS)
{
try
{
 clszx_OriginalPaperLogENEx objzx_OriginalPaperLogENT = new clszx_OriginalPaperLogENEx();
clszx_OriginalPaperLogBL.zx_OriginalPaperLogDA.CopyTo(objzx_OriginalPaperLogENS, objzx_OriginalPaperLogENT);
 return objzx_OriginalPaperLogENT;
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
public static List<clszx_OriginalPaperLogENEx> GetObjExLst(string strCondition)
{
List <clszx_OriginalPaperLogEN> arrObjLst = clszx_OriginalPaperLogBL.GetObjLst(strCondition);
List <clszx_OriginalPaperLogENEx> arrObjExLst = new List<clszx_OriginalPaperLogENEx>();
foreach (clszx_OriginalPaperLogEN objInFor in arrObjLst)
{
clszx_OriginalPaperLogENEx objzx_OriginalPaperLogENEx = new clszx_OriginalPaperLogENEx();
clszx_OriginalPaperLogBL.CopyTo(objInFor, objzx_OriginalPaperLogENEx);
arrObjExLst.Add(objzx_OriginalPaperLogENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngPaperLogId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_OriginalPaperLogENEx GetObjExByPaperLogId(long lngPaperLogId)
{
clszx_OriginalPaperLogEN objzx_OriginalPaperLogEN = clszx_OriginalPaperLogBL.GetObjByPaperLogId(lngPaperLogId);
clszx_OriginalPaperLogENEx objzx_OriginalPaperLogENEx = new clszx_OriginalPaperLogENEx();
clszx_OriginalPaperLogBL.CopyTo(objzx_OriginalPaperLogEN, objzx_OriginalPaperLogENEx);
return objzx_OriginalPaperLogENEx;
}
}
}