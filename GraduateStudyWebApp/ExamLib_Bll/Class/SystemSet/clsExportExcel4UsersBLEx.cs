
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcel4UsersBLEx
 表名:ExportExcel4Users(01120117)
 * 版本:2023.07.28.1(服务器:WIN-SRV103-116)
 日期:2023/08/13 05:31:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 public class RelatedActions_ExportExcel4UsersEx: RelatedActions_ExportExcel4Users
{
public override bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
public static class  clsExportExcel4UsersBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objExportExcel4UsersENS">源对象</param>
 /// <returns>目标对象=>clsExportExcel4UsersEN:objExportExcel4UsersENT</returns>
 public static clsExportExcel4UsersENEx CopyToEx(this clsExportExcel4UsersEN objExportExcel4UsersENS)
{
try
{
 clsExportExcel4UsersENEx objExportExcel4UsersENT = new clsExportExcel4UsersENEx();
clsExportExcel4UsersBL.ExportExcel4UsersDA.CopyTo(objExportExcel4UsersENS, objExportExcel4UsersENT);
 return objExportExcel4UsersENT;
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
 /// <param name = "objExportExcel4UsersENS">源对象</param>
 /// <returns>目标对象=>clsExportExcel4UsersEN:objExportExcel4UsersENT</returns>
 public static clsExportExcel4UsersEN CopyTo(this clsExportExcel4UsersENEx objExportExcel4UsersENS)
{
try
{
 clsExportExcel4UsersEN objExportExcel4UsersENT = new clsExportExcel4UsersEN();
clsExportExcel4UsersBL.CopyTo(objExportExcel4UsersENS, objExportExcel4UsersENT);
 return objExportExcel4UsersENT;
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
 /// 导出Excel用户字段(ExportExcel4Users)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsExportExcel4UsersBLEx : clsExportExcel4UsersBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsExportExcel4UsersDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsExportExcel4UsersDAEx ExportExcel4UsersDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsExportExcel4UsersDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objExportExcel4UsersENS">源对象</param>
 /// <returns>目标对象=>clsExportExcel4UsersEN:objExportExcel4UsersENT</returns>
 public static clsExportExcel4UsersENEx CopyToEx(clsExportExcel4UsersEN objExportExcel4UsersENS)
{
try
{
 clsExportExcel4UsersENEx objExportExcel4UsersENT = new clsExportExcel4UsersENEx();
clsExportExcel4UsersBL.ExportExcel4UsersDA.CopyTo(objExportExcel4UsersENS, objExportExcel4UsersENT);
 return objExportExcel4UsersENT;
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
public static List<clsExportExcel4UsersENEx> GetObjExLst(string strCondition)
{
List <clsExportExcel4UsersEN> arrObjLst = clsExportExcel4UsersBL.GetObjLst(strCondition);
List <clsExportExcel4UsersENEx> arrObjExLst = new List<clsExportExcel4UsersENEx>();
foreach (clsExportExcel4UsersEN objInFor in arrObjLst)
{
clsExportExcel4UsersENEx objExportExcel4UsersENEx = new clsExportExcel4UsersENEx();
clsExportExcel4UsersBL.CopyTo(objInFor, objExportExcel4UsersENEx);
arrObjExLst.Add(objExportExcel4UsersENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsExportExcel4UsersENEx GetObjExBymId(long lngmId)
{
clsExportExcel4UsersEN objExportExcel4UsersEN = clsExportExcel4UsersBL.GetObjBymId(lngmId);
clsExportExcel4UsersENEx objExportExcel4UsersENEx = new clsExportExcel4UsersENEx();
clsExportExcel4UsersBL.CopyTo(objExportExcel4UsersEN, objExportExcel4UsersENEx);
return objExportExcel4UsersENEx;
}
}
}