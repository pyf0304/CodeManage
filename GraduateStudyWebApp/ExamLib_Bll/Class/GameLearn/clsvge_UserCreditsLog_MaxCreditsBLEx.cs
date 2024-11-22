
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvge_UserCreditsLog_MaxCreditsBLEx
 表名:vge_UserCreditsLog_MaxCredits(01120939)
 生成代码版本:2022.11.24.1
 生成日期:2022/11/25 01:20:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 public class RelatedActions_vge_UserCreditsLog_MaxCreditsEx: RelatedActions_vge_UserCreditsLog_MaxCredits
{
public override bool UpdRelaTabDate(string strGameLevelId, string strOpUser)
{
return true;
}
}
public static class clsvge_UserCreditsLog_MaxCreditsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvge_UserCreditsLog_MaxCreditsENS">源对象</param>
 /// <returns>目标对象=>clsvge_UserCreditsLog_MaxCreditsEN:objvge_UserCreditsLog_MaxCreditsENT</returns>
 public static clsvge_UserCreditsLog_MaxCreditsENEx CopyToEx(this clsvge_UserCreditsLog_MaxCreditsEN objvge_UserCreditsLog_MaxCreditsENS)
{
try
{
 clsvge_UserCreditsLog_MaxCreditsENEx objvge_UserCreditsLog_MaxCreditsENT = new clsvge_UserCreditsLog_MaxCreditsENEx();
clsvge_UserCreditsLog_MaxCreditsBL.vge_UserCreditsLog_MaxCreditsDA.CopyTo(objvge_UserCreditsLog_MaxCreditsENS, objvge_UserCreditsLog_MaxCreditsENT);
 return objvge_UserCreditsLog_MaxCreditsENT;
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
 /// <param name = "objvge_UserCreditsLog_MaxCreditsENS">源对象</param>
 /// <returns>目标对象=>clsvge_UserCreditsLog_MaxCreditsEN:objvge_UserCreditsLog_MaxCreditsENT</returns>
 public static clsvge_UserCreditsLog_MaxCreditsEN CopyTo(this clsvge_UserCreditsLog_MaxCreditsENEx objvge_UserCreditsLog_MaxCreditsENS)
{
try
{
 clsvge_UserCreditsLog_MaxCreditsEN objvge_UserCreditsLog_MaxCreditsENT = new clsvge_UserCreditsLog_MaxCreditsEN();
clsvge_UserCreditsLog_MaxCreditsBL.CopyTo(objvge_UserCreditsLog_MaxCreditsENS, objvge_UserCreditsLog_MaxCreditsENT);
 return objvge_UserCreditsLog_MaxCreditsENT;
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
 /// v用户积分日志_最高分(vge_UserCreditsLog_MaxCredits)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvge_UserCreditsLog_MaxCreditsBLEx : clsvge_UserCreditsLog_MaxCreditsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvge_UserCreditsLog_MaxCreditsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvge_UserCreditsLog_MaxCreditsDAEx vge_UserCreditsLog_MaxCreditsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvge_UserCreditsLog_MaxCreditsDAEx();
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
public static List<clsvge_UserCreditsLog_MaxCreditsENEx> GetObjExLst(string strCondition)
{
List <clsvge_UserCreditsLog_MaxCreditsEN> arrObjLst = clsvge_UserCreditsLog_MaxCreditsBL.GetObjLst(strCondition);
List <clsvge_UserCreditsLog_MaxCreditsENEx> arrObjExLst = new List<clsvge_UserCreditsLog_MaxCreditsENEx>();
foreach (clsvge_UserCreditsLog_MaxCreditsEN objInFor in arrObjLst)
{
clsvge_UserCreditsLog_MaxCreditsENEx objvge_UserCreditsLog_MaxCreditsENEx = new clsvge_UserCreditsLog_MaxCreditsENEx();
clsvge_UserCreditsLog_MaxCreditsBL.CopyTo(objInFor, objvge_UserCreditsLog_MaxCreditsENEx);
arrObjExLst.Add(objvge_UserCreditsLog_MaxCreditsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strGameLevelId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvge_UserCreditsLog_MaxCreditsENEx GetObjExByGameLevelId(string strGameLevelId)
{
clsvge_UserCreditsLog_MaxCreditsEN objvge_UserCreditsLog_MaxCreditsEN = clsvge_UserCreditsLog_MaxCreditsBL.GetObjByGameLevelId(strGameLevelId);
clsvge_UserCreditsLog_MaxCreditsENEx objvge_UserCreditsLog_MaxCreditsENEx = new clsvge_UserCreditsLog_MaxCreditsENEx();
clsvge_UserCreditsLog_MaxCreditsBL.CopyTo(objvge_UserCreditsLog_MaxCreditsEN, objvge_UserCreditsLog_MaxCreditsENEx);
return objvge_UserCreditsLog_MaxCreditsENEx;
}
}
}