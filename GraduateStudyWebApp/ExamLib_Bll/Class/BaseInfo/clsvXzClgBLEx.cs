
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzClgBLEx
 表名:vXzClg(01120139)
 生成代码版本:2020.01.15.1
 生成日期:2020/01/16 13:53:49
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:基本信息维护
 模块英文名:BaseInfo
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
public static class clsvXzClgBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvXzClgENS">源对象</param>
 /// <returns>目标对象=>clsvXzClgEN:objvXzClgENT</returns>
 public static clsvXzClgENEx CopyToEx(this clsvXzClgEN objvXzClgENS)
{
try
{
 clsvXzClgENEx objvXzClgENT = new clsvXzClgENEx();
clsvXzClgBL.vXzClgDA.CopyTo(objvXzClgENS, objvXzClgENT);
 return objvXzClgENT;
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
 /// <param name = "objvXzClgENS">源对象</param>
 /// <returns>目标对象=>clsvXzClgEN:objvXzClgENT</returns>
 public static clsvXzClgEN CopyTo(this clsvXzClgENEx objvXzClgENS)
{
try
{
 clsvXzClgEN objvXzClgENT = new clsvXzClgEN();
clsvXzClgBL.CopyTo(objvXzClgENS, objvXzClgENT);
 return objvXzClgENT;
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
 /// v学院(vXzClg)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvXzClgBLEx : clsvXzClgBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvXzClgDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvXzClgDAEx vXzClgDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvXzClgDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvXzClgENEx> GetObjExLst(string strCondition)
{
List <clsvXzClgEN> arrObjLst = clsvXzClgBL.GetObjLst(strCondition);
List <clsvXzClgENEx> arrObjExLst = new List<clsvXzClgENEx>();
foreach (clsvXzClgEN objInFor in arrObjLst)
{
clsvXzClgENEx objvXzClgENEx = new clsvXzClgENEx();
clsvXzClgBL.CopyTo(objInFor, objvXzClgENEx);
arrObjExLst.Add(objvXzClgENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_XzCollege">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvXzClgENEx GetObjExByid_XzCollege(string strid_XzCollege)
{
clsvXzClgEN objvXzClgEN = clsvXzClgBL.GetObjByIdXzCollege(strid_XzCollege);
clsvXzClgENEx objvXzClgENEx = new clsvXzClgENEx();
clsvXzClgBL.CopyTo(objvXzClgEN, objvXzClgENEx);
return objvXzClgENEx;
}
}
}