
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzAdminClsTypeBLEx
 表名:XzAdminClsType(01120195)
 生成代码版本:2021.08.17.1
 生成日期:2021/08/19 23:17:50
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:人员管理
 模块英文名:PeopleManage
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
public static class clsXzAdminClsTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objXzAdminClsTypeENS">源对象</param>
 /// <returns>目标对象=>clsXzAdminClsTypeEN:objXzAdminClsTypeENT</returns>
 public static clsXzAdminClsTypeENEx CopyToEx(this clsXzAdminClsTypeEN objXzAdminClsTypeENS)
{
try
{
 clsXzAdminClsTypeENEx objXzAdminClsTypeENT = new clsXzAdminClsTypeENEx();
clsXzAdminClsTypeBL.XzAdminClsTypeDA.CopyTo(objXzAdminClsTypeENS, objXzAdminClsTypeENT);
 return objXzAdminClsTypeENT;
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
 /// <param name = "objXzAdminClsTypeENS">源对象</param>
 /// <returns>目标对象=>clsXzAdminClsTypeEN:objXzAdminClsTypeENT</returns>
 public static clsXzAdminClsTypeEN CopyTo(this clsXzAdminClsTypeENEx objXzAdminClsTypeENS)
{
try
{
 clsXzAdminClsTypeEN objXzAdminClsTypeENT = new clsXzAdminClsTypeEN();
clsXzAdminClsTypeBL.CopyTo(objXzAdminClsTypeENS, objXzAdminClsTypeENT);
 return objXzAdminClsTypeENT;
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
 /// 行政班类型(XzAdminClsType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsXzAdminClsTypeBLEx : clsXzAdminClsTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsXzAdminClsTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsXzAdminClsTypeDAEx XzAdminClsTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsXzAdminClsTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objXzAdminClsTypeENS">源对象</param>
 /// <returns>目标对象=>clsXzAdminClsTypeEN:objXzAdminClsTypeENT</returns>
 public static clsXzAdminClsTypeENEx CopyToEx(clsXzAdminClsTypeEN objXzAdminClsTypeENS)
{
try
{
 clsXzAdminClsTypeENEx objXzAdminClsTypeENT = new clsXzAdminClsTypeENEx();
clsXzAdminClsTypeBL.XzAdminClsTypeDA.CopyTo(objXzAdminClsTypeENS, objXzAdminClsTypeENT);
 return objXzAdminClsTypeENT;
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
public static List<clsXzAdminClsTypeENEx> GetObjExLst(string strCondition)
{
List <clsXzAdminClsTypeEN> arrObjLst = clsXzAdminClsTypeBL.GetObjLst(strCondition);
List <clsXzAdminClsTypeENEx> arrObjExLst = new List<clsXzAdminClsTypeENEx>();
foreach (clsXzAdminClsTypeEN objInFor in arrObjLst)
{
clsXzAdminClsTypeENEx objXzAdminClsTypeENEx = new clsXzAdminClsTypeENEx();
clsXzAdminClsTypeBL.CopyTo(objInFor, objXzAdminClsTypeENEx);
arrObjExLst.Add(objXzAdminClsTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_AdminClsType">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsXzAdminClsTypeENEx GetObjExByid_AdminClsType(string strid_AdminClsType)
{
clsXzAdminClsTypeEN objXzAdminClsTypeEN = clsXzAdminClsTypeBL.GetObjByIdAdminClsType(strid_AdminClsType);
clsXzAdminClsTypeENEx objXzAdminClsTypeENEx = new clsXzAdminClsTypeENEx();
clsXzAdminClsTypeBL.CopyTo(objXzAdminClsTypeEN, objXzAdminClsTypeENEx);
return objXzAdminClsTypeENEx;
}
}
}