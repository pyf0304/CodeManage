
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_UnitBLEx
 表名:zx_Unit(01120713)
 生成代码版本:2020.07.31.1
 生成日期:2020/07/31 22:47:33
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
public static class clszx_UnitBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_UnitENS">源对象</param>
 /// <returns>目标对象=>clszx_UnitEN:objzx_UnitENT</returns>
 public static clszx_UnitENEx CopyToEx(this clszx_UnitEN objzx_UnitENS)
{
try
{
 clszx_UnitENEx objzx_UnitENT = new clszx_UnitENEx();
clszx_UnitBL.zx_UnitDA.CopyTo(objzx_UnitENS, objzx_UnitENT);
 return objzx_UnitENT;
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
 /// <param name = "objzx_UnitENS">源对象</param>
 /// <returns>目标对象=>clszx_UnitEN:objzx_UnitENT</returns>
 public static clszx_UnitEN CopyTo(this clszx_UnitENEx objzx_UnitENS)
{
try
{
 clszx_UnitEN objzx_UnitENT = new clszx_UnitEN();
clszx_UnitBL.CopyTo(objzx_UnitENS, objzx_UnitENT);
 return objzx_UnitENT;
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
 /// 中学课件单元表(zx_Unit)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_UnitBLEx : clszx_UnitBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_UnitDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_UnitDAEx zx_UnitDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_UnitDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_UnitENS">源对象</param>
 /// <returns>目标对象=>clszx_UnitEN:objzx_UnitENT</returns>
 public static clszx_UnitENEx CopyToEx(clszx_UnitEN objzx_UnitENS)
{
try
{
 clszx_UnitENEx objzx_UnitENT = new clszx_UnitENEx();
clszx_UnitBL.zx_UnitDA.CopyTo(objzx_UnitENS, objzx_UnitENT);
 return objzx_UnitENT;
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
public static List<clszx_UnitENEx> GetObjExLst(string strCondition)
{
List <clszx_UnitEN> arrObjLst = clszx_UnitBL.GetObjLst(strCondition);
List <clszx_UnitENEx> arrObjExLst = new List<clszx_UnitENEx>();
foreach (clszx_UnitEN objInFor in arrObjLst)
{
clszx_UnitENEx objzx_UnitENEx = new clszx_UnitENEx();
clszx_UnitBL.CopyTo(objInFor, objzx_UnitENEx);
arrObjExLst.Add(objzx_UnitENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strUnitId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_UnitENEx GetObjExByUnitId(string strUnitId)
{
clszx_UnitEN objzx_UnitEN = clszx_UnitBL.GetObjByUnitId(strUnitId);
clszx_UnitENEx objzx_UnitENEx = new clszx_UnitENEx();
clszx_UnitBL.CopyTo(objzx_UnitEN, objzx_UnitENEx);
return objzx_UnitENEx;
}
}
}