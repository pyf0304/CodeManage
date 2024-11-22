
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersSimBLEx
 表名:vUsersSim(01120699)
 生成代码版本:2020.07.06.1
 生成日期:2020/07/09 10:45:58
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:用户管理
 模块英文名:UserManage
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
public static class clsvUsersSimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvUsersSimENS">源对象</param>
 /// <returns>目标对象=>clsvUsersSimEN:objvUsersSimENT</returns>
 public static clsvUsersSimENEx CopyToEx(this clsvUsersSimEN objvUsersSimENS)
{
try
{
 clsvUsersSimENEx objvUsersSimENT = new clsvUsersSimENEx();
clsvUsersSimBL.vUsersSimDA.CopyTo(objvUsersSimENS, objvUsersSimENT);
 return objvUsersSimENT;
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
 /// <param name = "objvUsersSimENS">源对象</param>
 /// <returns>目标对象=>clsvUsersSimEN:objvUsersSimENT</returns>
 public static clsvUsersSimEN CopyTo(this clsvUsersSimENEx objvUsersSimENS)
{
try
{
 clsvUsersSimEN objvUsersSimENT = new clsvUsersSimEN();
clsvUsersSimBL.CopyTo(objvUsersSimENS, objvUsersSimENT);
 return objvUsersSimENT;
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
 /// vUsersSim(vUsersSim)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvUsersSimBLEx : clsvUsersSimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvUsersSimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvUsersSimDAEx vUsersSimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvUsersSimDAEx();
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
public static List<clsvUsersSimENEx> GetObjExLst(string strCondition)
{
List <clsvUsersSimEN> arrObjLst = clsvUsersSimBL.GetObjLst(strCondition);
List <clsvUsersSimENEx> arrObjExLst = new List<clsvUsersSimENEx>();
foreach (clsvUsersSimEN objInFor in arrObjLst)
{
clsvUsersSimENEx objvUsersSimENEx = new clsvUsersSimENEx();
clsvUsersSimBL.CopyTo(objInFor, objvUsersSimENEx);
arrObjExLst.Add(objvUsersSimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvUsersSimENEx GetObjExByUserId(string strUserId)
{
clsvUsersSimEN objvUsersSimEN = clsvUsersSimBL.GetObjByUserId(strUserId);
clsvUsersSimENEx objvUsersSimENEx = new clsvUsersSimENEx();
clsvUsersSimBL.CopyTo(objvUsersSimEN, objvUsersSimENEx);
return objvUsersSimENEx;
}
}
}