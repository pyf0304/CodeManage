
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduCls_SimBLEx
 表名:vCurrEduCls_Sim(01120951)
 * 版本:2023.07.28.1(服务器:WIN-SRV103-116)
 日期:2023/08/13 06:25:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 public class RelatedActions_vCurrEduCls_SimEx: RelatedActions_vCurrEduCls_Sim
{
public override bool UpdRelaTabDate(string strid_CurrEduCls, string strOpUser)
{
return true;
}
}
public static class  clsvCurrEduCls_SimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimENS">源对象</param>
 /// <returns>目标对象=>clsvCurrEduCls_SimEN:objvCurrEduCls_SimENT</returns>
 public static clsvCurrEduCls_SimENEx CopyToEx(this clsvCurrEduCls_SimEN objvCurrEduCls_SimENS)
{
try
{
 clsvCurrEduCls_SimENEx objvCurrEduCls_SimENT = new clsvCurrEduCls_SimENEx();
clsvCurrEduCls_SimBL.vCurrEduCls_SimDA.CopyTo(objvCurrEduCls_SimENS, objvCurrEduCls_SimENT);
 return objvCurrEduCls_SimENT;
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
 /// <param name = "objvCurrEduCls_SimENS">源对象</param>
 /// <returns>目标对象=>clsvCurrEduCls_SimEN:objvCurrEduCls_SimENT</returns>
 public static clsvCurrEduCls_SimEN CopyTo(this clsvCurrEduCls_SimENEx objvCurrEduCls_SimENS)
{
try
{
 clsvCurrEduCls_SimEN objvCurrEduCls_SimENT = new clsvCurrEduCls_SimEN();
clsvCurrEduCls_SimBL.CopyTo(objvCurrEduCls_SimENS, objvCurrEduCls_SimENT);
 return objvCurrEduCls_SimENT;
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
 /// vCurrEduCls_Sim(vCurrEduCls_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsvCurrEduCls_SimBLEx : clsvCurrEduCls_SimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvCurrEduCls_SimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvCurrEduCls_SimDAEx vCurrEduCls_SimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvCurrEduCls_SimDAEx();
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
public static List<clsvCurrEduCls_SimENEx> GetObjExLst(string strCondition)
{
List <clsvCurrEduCls_SimEN> arrObjLst = clsvCurrEduCls_SimBL.GetObjLst(strCondition);
List <clsvCurrEduCls_SimENEx> arrObjExLst = new List<clsvCurrEduCls_SimENEx>();
foreach (clsvCurrEduCls_SimEN objInFor in arrObjLst)
{
clsvCurrEduCls_SimENEx objvCurrEduCls_SimENEx = new clsvCurrEduCls_SimENEx();
clsvCurrEduCls_SimBL.CopyTo(objInFor, objvCurrEduCls_SimENEx);
arrObjExLst.Add(objvCurrEduCls_SimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_CurrEduCls">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvCurrEduCls_SimENEx GetObjExByid_CurrEduCls(string strid_CurrEduCls)
{
clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = clsvCurrEduCls_SimBL.GetObjByid_CurrEduCls(strid_CurrEduCls);
clsvCurrEduCls_SimENEx objvCurrEduCls_SimENEx = new clsvCurrEduCls_SimENEx();
clsvCurrEduCls_SimBL.CopyTo(objvCurrEduCls_SimEN, objvCurrEduCls_SimENEx);
return objvCurrEduCls_SimENEx;
}
}
}