
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsManagedDepartmentBLEx
 表名:ManagedDepartment(01120228)
 * 版本:2023.07.28.1(服务器:WIN-SRV103-116)
 日期:2023/08/13 05:31:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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

using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_ManagedDepartmentEx: RelatedActions_ManagedDepartment
{
public override bool UpdRelaTabDate(string strManagedDepartmentId, string strOpUser)
{
return true;
}
}
public static class  clsManagedDepartmentBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objManagedDepartmentENS">源对象</param>
 /// <returns>目标对象=>clsManagedDepartmentEN:objManagedDepartmentENT</returns>
 public static clsManagedDepartmentENEx CopyToEx(this clsManagedDepartmentEN objManagedDepartmentENS)
{
try
{
 clsManagedDepartmentENEx objManagedDepartmentENT = new clsManagedDepartmentENEx();
clsManagedDepartmentBL.ManagedDepartmentDA.CopyTo(objManagedDepartmentENS, objManagedDepartmentENT);
 return objManagedDepartmentENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objManagedDepartmentENS">源对象</param>
 /// <returns>目标对象=>clsManagedDepartmentEN:objManagedDepartmentENT</returns>
 public static clsManagedDepartmentEN CopyTo(this clsManagedDepartmentENEx objManagedDepartmentENS)
{
try
{
 clsManagedDepartmentEN objManagedDepartmentENT = new clsManagedDepartmentEN();
clsManagedDepartmentBL.CopyTo(objManagedDepartmentENS, objManagedDepartmentENT);
 return objManagedDepartmentENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 管理的部门(ManagedDepartment)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsManagedDepartmentBLEx : clsManagedDepartmentBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsManagedDepartmentDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsManagedDepartmentDAEx ManagedDepartmentDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsManagedDepartmentDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objManagedDepartmentENS">源对象</param>
 /// <returns>目标对象=>clsManagedDepartmentEN:objManagedDepartmentENT</returns>
 public static clsManagedDepartmentENEx CopyToEx(clsManagedDepartmentEN objManagedDepartmentENS)
{
try
{
 clsManagedDepartmentENEx objManagedDepartmentENT = new clsManagedDepartmentENEx();
clsManagedDepartmentBL.ManagedDepartmentDA.CopyTo(objManagedDepartmentENS, objManagedDepartmentENT);
 return objManagedDepartmentENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
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
public static List<clsManagedDepartmentENEx> GetObjExLst(string strCondition)
{
List <clsManagedDepartmentEN> arrObjLst = clsManagedDepartmentBL.GetObjLst(strCondition);
List <clsManagedDepartmentENEx> arrObjExLst = new List<clsManagedDepartmentENEx>();
foreach (clsManagedDepartmentEN objInFor in arrObjLst)
{
clsManagedDepartmentENEx objManagedDepartmentENEx = new clsManagedDepartmentENEx();
clsManagedDepartmentBL.CopyTo(objInFor, objManagedDepartmentENEx);
arrObjExLst.Add(objManagedDepartmentENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strManagedDepartmentId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsManagedDepartmentENEx GetObjExByManagedDepartmentId(string strManagedDepartmentId)
{
clsManagedDepartmentEN objManagedDepartmentEN = clsManagedDepartmentBL.GetObjByManagedDepartmentId(strManagedDepartmentId);
clsManagedDepartmentENEx objManagedDepartmentENEx = new clsManagedDepartmentENEx();
clsManagedDepartmentBL.CopyTo(objManagedDepartmentEN, objManagedDepartmentENEx);
return objManagedDepartmentENEx;
}
}
}