
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewpointVerBLEx
 表名:ViewpointVer(01120650)
 * 版本:2023.01.08.1(服务器:WIN-SRV103-116)
 日期:2023/01/08 16:06:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
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
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_ViewpointVerEx: RelatedActions_ViewpointVer
{
public override bool UpdRelaTabDate(long lngViewpointVId, string strOpUser)
{
return true;
}
}
public static class clsViewpointVerBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objViewpointVerENS">源对象</param>
 /// <returns>目标对象=>clsViewpointVerEN:objViewpointVerENT</returns>
 public static clsViewpointVerENEx CopyToEx(this clsViewpointVerEN objViewpointVerENS)
{
try
{
 clsViewpointVerENEx objViewpointVerENT = new clsViewpointVerENEx();
clsViewpointVerBL.ViewpointVerDA.CopyTo(objViewpointVerENS, objViewpointVerENT);
 return objViewpointVerENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objViewpointVerENS">源对象</param>
 /// <returns>目标对象=>clsViewpointVerEN:objViewpointVerENT</returns>
 public static clsViewpointVerEN CopyTo(this clsViewpointVerENEx objViewpointVerENS)
{
try
{
 clsViewpointVerEN objViewpointVerENT = new clsViewpointVerEN();
clsViewpointVerBL.CopyTo(objViewpointVerENS, objViewpointVerENT);
 return objViewpointVerENT;
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
 /// 观点版本表(ViewpointVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsViewpointVerBLEx : clsViewpointVerBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsViewpointVerDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsViewpointVerDAEx ViewpointVerDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsViewpointVerDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objViewpointVerENS">源对象</param>
 /// <returns>目标对象=>clsViewpointVerEN:objViewpointVerENT</returns>
 public static clsViewpointVerENEx CopyToEx(clsViewpointVerEN objViewpointVerENS)
{
try
{
 clsViewpointVerENEx objViewpointVerENT = new clsViewpointVerENEx();
clsViewpointVerBL.ViewpointVerDA.CopyTo(objViewpointVerENS, objViewpointVerENT);
 return objViewpointVerENT;
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
public static List<clsViewpointVerENEx> GetObjExLst(string strCondition)
{
List <clsViewpointVerEN> arrObjLst = clsViewpointVerBL.GetObjLst(strCondition);
List <clsViewpointVerENEx> arrObjExLst = new List<clsViewpointVerENEx>();
foreach (clsViewpointVerEN objInFor in arrObjLst)
{
clsViewpointVerENEx objViewpointVerENEx = new clsViewpointVerENEx();
clsViewpointVerBL.CopyTo(objInFor, objViewpointVerENEx);
arrObjExLst.Add(objViewpointVerENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngViewpointVId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsViewpointVerENEx GetObjExByViewpointVId(long lngViewpointVId)
{
clsViewpointVerEN objViewpointVerEN = clsViewpointVerBL.GetObjByViewpointVId(lngViewpointVId);
clsViewpointVerENEx objViewpointVerENEx = new clsViewpointVerENEx();
clsViewpointVerBL.CopyTo(objViewpointVerEN, objViewpointVerENEx);
return objViewpointVerENEx;
}
}
}