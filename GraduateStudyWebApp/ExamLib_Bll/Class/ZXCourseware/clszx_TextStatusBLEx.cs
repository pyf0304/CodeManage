
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextStatusBLEx
 表名:zx_TextStatus(01120710)
 生成代码版本:2020.07.31.1
 生成日期:2020/07/31 22:47:28
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:中学生课件管理
 模块英文名:ZXCourseware
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
public static class clszx_TextStatusBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TextStatusENS">源对象</param>
 /// <returns>目标对象=>clszx_TextStatusEN:objzx_TextStatusENT</returns>
 public static clszx_TextStatusENEx CopyToEx(this clszx_TextStatusEN objzx_TextStatusENS)
{
try
{
 clszx_TextStatusENEx objzx_TextStatusENT = new clszx_TextStatusENEx();
clszx_TextStatusBL.zx_TextStatusDA.CopyTo(objzx_TextStatusENS, objzx_TextStatusENT);
 return objzx_TextStatusENT;
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
 /// <param name = "objzx_TextStatusENS">源对象</param>
 /// <returns>目标对象=>clszx_TextStatusEN:objzx_TextStatusENT</returns>
 public static clszx_TextStatusEN CopyTo(this clszx_TextStatusENEx objzx_TextStatusENS)
{
try
{
 clszx_TextStatusEN objzx_TextStatusENT = new clszx_TextStatusEN();
clszx_TextStatusBL.CopyTo(objzx_TextStatusENS, objzx_TextStatusENT);
 return objzx_TextStatusENT;
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
 /// 中学课件状态(zx_TextStatus)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_TextStatusBLEx : clszx_TextStatusBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_TextStatusDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_TextStatusDAEx zx_TextStatusDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_TextStatusDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TextStatusENS">源对象</param>
 /// <returns>目标对象=>clszx_TextStatusEN:objzx_TextStatusENT</returns>
 public static clszx_TextStatusENEx CopyToEx(clszx_TextStatusEN objzx_TextStatusENS)
{
try
{
 clszx_TextStatusENEx objzx_TextStatusENT = new clszx_TextStatusENEx();
clszx_TextStatusBL.zx_TextStatusDA.CopyTo(objzx_TextStatusENS, objzx_TextStatusENT);
 return objzx_TextStatusENT;
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
public static List<clszx_TextStatusENEx> GetObjExLst(string strCondition)
{
List <clszx_TextStatusEN> arrObjLst = clszx_TextStatusBL.GetObjLst(strCondition);
List <clszx_TextStatusENEx> arrObjExLst = new List<clszx_TextStatusENEx>();
foreach (clszx_TextStatusEN objInFor in arrObjLst)
{
clszx_TextStatusENEx objzx_TextStatusENEx = new clszx_TextStatusENEx();
clszx_TextStatusBL.CopyTo(objInFor, objzx_TextStatusENEx);
arrObjExLst.Add(objzx_TextStatusENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTextStatusId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_TextStatusENEx GetObjExByTextStatusId(string strTextStatusId)
{
clszx_TextStatusEN objzx_TextStatusEN = clszx_TextStatusBL.GetObjByTextStatusId(strTextStatusId);
clszx_TextStatusENEx objzx_TextStatusENEx = new clszx_TextStatusENEx();
clszx_TextStatusBL.CopyTo(objzx_TextStatusEN, objzx_TextStatusENEx);
return objzx_TextStatusENEx;
}
}
}