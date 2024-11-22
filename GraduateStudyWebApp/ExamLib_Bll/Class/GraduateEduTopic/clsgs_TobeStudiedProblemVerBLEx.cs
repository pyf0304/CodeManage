
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TobeStudiedProblemVerBLEx
 表名:gs_TobeStudiedProblemVer(01120775)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 日期:2023/01/12 15:18:57
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
 public class RelatedActions_gs_TobeStudiedProblemVerEx: RelatedActions_gs_TobeStudiedProblemVer
{
public override bool UpdRelaTabDate(long lngProblemVId, string strOpUser)
{
return true;
}
}
public static class clsgs_TobeStudiedProblemVerBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemVerENS">源对象</param>
 /// <returns>目标对象=>clsgs_TobeStudiedProblemVerEN:objgs_TobeStudiedProblemVerENT</returns>
 public static clsgs_TobeStudiedProblemVerENEx CopyToEx(this clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerENS)
{
try
{
 clsgs_TobeStudiedProblemVerENEx objgs_TobeStudiedProblemVerENT = new clsgs_TobeStudiedProblemVerENEx();
clsgs_TobeStudiedProblemVerBL.gs_TobeStudiedProblemVerDA.CopyTo(objgs_TobeStudiedProblemVerENS, objgs_TobeStudiedProblemVerENT);
 return objgs_TobeStudiedProblemVerENT;
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
 /// <param name = "objgs_TobeStudiedProblemVerENS">源对象</param>
 /// <returns>目标对象=>clsgs_TobeStudiedProblemVerEN:objgs_TobeStudiedProblemVerENT</returns>
 public static clsgs_TobeStudiedProblemVerEN CopyTo(this clsgs_TobeStudiedProblemVerENEx objgs_TobeStudiedProblemVerENS)
{
try
{
 clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerENT = new clsgs_TobeStudiedProblemVerEN();
clsgs_TobeStudiedProblemVerBL.CopyTo(objgs_TobeStudiedProblemVerENS, objgs_TobeStudiedProblemVerENT);
 return objgs_TobeStudiedProblemVerENT;
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
 /// 待研究问题历史版本表(gs_TobeStudiedProblemVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_TobeStudiedProblemVerBLEx : clsgs_TobeStudiedProblemVerBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_TobeStudiedProblemVerDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_TobeStudiedProblemVerDAEx gs_TobeStudiedProblemVerDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_TobeStudiedProblemVerDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemVerENS">源对象</param>
 /// <returns>目标对象=>clsgs_TobeStudiedProblemVerEN:objgs_TobeStudiedProblemVerENT</returns>
 public static clsgs_TobeStudiedProblemVerENEx CopyToEx(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerENS)
{
try
{
 clsgs_TobeStudiedProblemVerENEx objgs_TobeStudiedProblemVerENT = new clsgs_TobeStudiedProblemVerENEx();
clsgs_TobeStudiedProblemVerBL.gs_TobeStudiedProblemVerDA.CopyTo(objgs_TobeStudiedProblemVerENS, objgs_TobeStudiedProblemVerENT);
 return objgs_TobeStudiedProblemVerENT;
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
public static List<clsgs_TobeStudiedProblemVerENEx> GetObjExLst(string strCondition)
{
List <clsgs_TobeStudiedProblemVerEN> arrObjLst = clsgs_TobeStudiedProblemVerBL.GetObjLst(strCondition);
List <clsgs_TobeStudiedProblemVerENEx> arrObjExLst = new List<clsgs_TobeStudiedProblemVerENEx>();
foreach (clsgs_TobeStudiedProblemVerEN objInFor in arrObjLst)
{
clsgs_TobeStudiedProblemVerENEx objgs_TobeStudiedProblemVerENEx = new clsgs_TobeStudiedProblemVerENEx();
clsgs_TobeStudiedProblemVerBL.CopyTo(objInFor, objgs_TobeStudiedProblemVerENEx);
arrObjExLst.Add(objgs_TobeStudiedProblemVerENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngProblemVId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_TobeStudiedProblemVerENEx GetObjExByProblemVId(long lngProblemVId)
{
clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN = clsgs_TobeStudiedProblemVerBL.GetObjByProblemVId(lngProblemVId);
clsgs_TobeStudiedProblemVerENEx objgs_TobeStudiedProblemVerENEx = new clsgs_TobeStudiedProblemVerENEx();
clsgs_TobeStudiedProblemVerBL.CopyTo(objgs_TobeStudiedProblemVerEN, objgs_TobeStudiedProblemVerENEx);
return objgs_TobeStudiedProblemVerENEx;
}
}
}