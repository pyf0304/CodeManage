
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TobeStudiedProblemVerBLEx
 表名:zx_TobeStudiedProblemVer(01120805)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 日期:2023/01/12 15:28:40
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
 public class RelatedActions_zx_TobeStudiedProblemVerEx: RelatedActions_zx_TobeStudiedProblemVer
{
public override bool UpdRelaTabDate(long lngProblemVId, string strOpUser)
{
return true;
}
}
public static class clszx_TobeStudiedProblemVerBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerENS">源对象</param>
 /// <returns>目标对象=>clszx_TobeStudiedProblemVerEN:objzx_TobeStudiedProblemVerENT</returns>
 public static clszx_TobeStudiedProblemVerENEx CopyToEx(this clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENS)
{
try
{
 clszx_TobeStudiedProblemVerENEx objzx_TobeStudiedProblemVerENT = new clszx_TobeStudiedProblemVerENEx();
clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.CopyTo(objzx_TobeStudiedProblemVerENS, objzx_TobeStudiedProblemVerENT);
 return objzx_TobeStudiedProblemVerENT;
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
 /// <param name = "objzx_TobeStudiedProblemVerENS">源对象</param>
 /// <returns>目标对象=>clszx_TobeStudiedProblemVerEN:objzx_TobeStudiedProblemVerENT</returns>
 public static clszx_TobeStudiedProblemVerEN CopyTo(this clszx_TobeStudiedProblemVerENEx objzx_TobeStudiedProblemVerENS)
{
try
{
 clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENT = new clszx_TobeStudiedProblemVerEN();
clszx_TobeStudiedProblemVerBL.CopyTo(objzx_TobeStudiedProblemVerENS, objzx_TobeStudiedProblemVerENT);
 return objzx_TobeStudiedProblemVerENT;
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
 /// 中学待研究问题历史版本表(zx_TobeStudiedProblemVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_TobeStudiedProblemVerBLEx : clszx_TobeStudiedProblemVerBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_TobeStudiedProblemVerDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_TobeStudiedProblemVerDAEx zx_TobeStudiedProblemVerDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_TobeStudiedProblemVerDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerENS">源对象</param>
 /// <returns>目标对象=>clszx_TobeStudiedProblemVerEN:objzx_TobeStudiedProblemVerENT</returns>
 public static clszx_TobeStudiedProblemVerENEx CopyToEx(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENS)
{
try
{
 clszx_TobeStudiedProblemVerENEx objzx_TobeStudiedProblemVerENT = new clszx_TobeStudiedProblemVerENEx();
clszx_TobeStudiedProblemVerBL.zx_TobeStudiedProblemVerDA.CopyTo(objzx_TobeStudiedProblemVerENS, objzx_TobeStudiedProblemVerENT);
 return objzx_TobeStudiedProblemVerENT;
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
public static List<clszx_TobeStudiedProblemVerENEx> GetObjExLst(string strCondition)
{
List <clszx_TobeStudiedProblemVerEN> arrObjLst = clszx_TobeStudiedProblemVerBL.GetObjLst(strCondition);
List <clszx_TobeStudiedProblemVerENEx> arrObjExLst = new List<clszx_TobeStudiedProblemVerENEx>();
foreach (clszx_TobeStudiedProblemVerEN objInFor in arrObjLst)
{
clszx_TobeStudiedProblemVerENEx objzx_TobeStudiedProblemVerENEx = new clszx_TobeStudiedProblemVerENEx();
clszx_TobeStudiedProblemVerBL.CopyTo(objInFor, objzx_TobeStudiedProblemVerENEx);
arrObjExLst.Add(objzx_TobeStudiedProblemVerENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngProblemVId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_TobeStudiedProblemVerENEx GetObjExByProblemVId(long lngProblemVId)
{
clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = clszx_TobeStudiedProblemVerBL.GetObjByProblemVId(lngProblemVId);
clszx_TobeStudiedProblemVerENEx objzx_TobeStudiedProblemVerENEx = new clszx_TobeStudiedProblemVerENEx();
clszx_TobeStudiedProblemVerBL.CopyTo(objzx_TobeStudiedProblemVerEN, objzx_TobeStudiedProblemVerENEx);
return objzx_TobeStudiedProblemVerENEx;
}
}
}