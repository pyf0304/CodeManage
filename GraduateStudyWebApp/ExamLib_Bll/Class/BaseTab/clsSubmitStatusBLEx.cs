
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSubmitStatusBLEx
 表名:SubmitStatus(01120970)
 * 版本:2024.04.16.1(服务器:WIN-SRV103-116)
 日期:2024/05/03 11:53:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本表(BaseTab)
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
 public class RelatedActions_SubmitStatusEx: RelatedActions_SubmitStatus
{
public override bool UpdRelaTabDate(string strIdSubmitStatus, string strOpUser)
{
return true;
}
}
public static class  clsSubmitStatusBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objSubmitStatusENS">源对象</param>
 /// <returns>目标对象=>clsSubmitStatusEN:objSubmitStatusENT</returns>
 public static clsSubmitStatusENEx CopyToEx(this clsSubmitStatusEN objSubmitStatusENS)
{
try
{
 clsSubmitStatusENEx objSubmitStatusENT = new clsSubmitStatusENEx();
clsSubmitStatusBL.SubmitStatusDA.CopyTo(objSubmitStatusENS, objSubmitStatusENT);
 return objSubmitStatusENT;
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
 /// <param name = "objSubmitStatusENS">源对象</param>
 /// <returns>目标对象=>clsSubmitStatusEN:objSubmitStatusENT</returns>
 public static clsSubmitStatusEN CopyTo(this clsSubmitStatusENEx objSubmitStatusENS)
{
try
{
 clsSubmitStatusEN objSubmitStatusENT = new clsSubmitStatusEN();
clsSubmitStatusBL.CopyTo(objSubmitStatusENS, objSubmitStatusENT);
 return objSubmitStatusENT;
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
 /// 送审状态(SubmitStatus)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsSubmitStatusBLEx : clsSubmitStatusBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsSubmitStatusDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsSubmitStatusDAEx SubmitStatusDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsSubmitStatusDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objSubmitStatusENS">源对象</param>
 /// <returns>目标对象=>clsSubmitStatusEN:objSubmitStatusENT</returns>
 public static clsSubmitStatusENEx CopyToEx(clsSubmitStatusEN objSubmitStatusENS)
{
try
{
 clsSubmitStatusENEx objSubmitStatusENT = new clsSubmitStatusENEx();
clsSubmitStatusBL.SubmitStatusDA.CopyTo(objSubmitStatusENS, objSubmitStatusENT);
 return objSubmitStatusENT;
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
public static List<clsSubmitStatusENEx> GetObjExLst(string strCondition)
{
List <clsSubmitStatusEN> arrObjLst = clsSubmitStatusBL.GetObjLst(strCondition);
List <clsSubmitStatusENEx> arrObjExLst = new List<clsSubmitStatusENEx>();
foreach (clsSubmitStatusEN objInFor in arrObjLst)
{
clsSubmitStatusENEx objSubmitStatusENEx = new clsSubmitStatusENEx();
clsSubmitStatusBL.CopyTo(objInFor, objSubmitStatusENEx);
arrObjExLst.Add(objSubmitStatusENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strIdSubmitStatus">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsSubmitStatusENEx GetObjExByIdSubmitStatus(string strIdSubmitStatus)
{
clsSubmitStatusEN objSubmitStatusEN = clsSubmitStatusBL.GetObjByIdSubmitStatus(strIdSubmitStatus);
clsSubmitStatusENEx objSubmitStatusENEx = new clsSubmitStatusENEx();
clsSubmitStatusBL.CopyTo(objSubmitStatusEN, objSubmitStatusENEx);
return objSubmitStatusENEx;
}
}
}