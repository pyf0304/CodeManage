
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_SimBLEx
 表名:vQuestionnaire_Sim(01120949)
 * 版本:2023.07.28.1(服务器:WIN-SRV103-116)
 日期:2023/08/13 06:25:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息(BaseInfo)
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
 public class RelatedActions_vQuestionnaire_SimEx: RelatedActions_vQuestionnaire_Sim
{
public override bool UpdRelaTabDate(long strQuestionId, string strOpUser)
{
return true;
}
}
public static class  clsvQuestionnaire_SimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire_SimEN:objvQuestionnaire_SimENT</returns>
 public static clsvQuestionnaire_SimENEx CopyToEx(this clsvQuestionnaire_SimEN objvQuestionnaire_SimENS)
{
try
{
 clsvQuestionnaire_SimENEx objvQuestionnaire_SimENT = new clsvQuestionnaire_SimENEx();
clsvQuestionnaire_SimBL.vQuestionnaire_SimDA.CopyTo(objvQuestionnaire_SimENS, objvQuestionnaire_SimENT);
 return objvQuestionnaire_SimENT;
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
 /// <param name = "objvQuestionnaire_SimENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire_SimEN:objvQuestionnaire_SimENT</returns>
 public static clsvQuestionnaire_SimEN CopyTo(this clsvQuestionnaire_SimENEx objvQuestionnaire_SimENS)
{
try
{
 clsvQuestionnaire_SimEN objvQuestionnaire_SimENT = new clsvQuestionnaire_SimEN();
clsvQuestionnaire_SimBL.CopyTo(objvQuestionnaire_SimENS, objvQuestionnaire_SimENT);
 return objvQuestionnaire_SimENT;
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
 /// vQuestionnaire_Sim(vQuestionnaire_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsvQuestionnaire_SimBLEx : clsvQuestionnaire_SimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvQuestionnaire_SimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvQuestionnaire_SimDAEx vQuestionnaire_SimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvQuestionnaire_SimDAEx();
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
public static List<clsvQuestionnaire_SimENEx> GetObjExLst(string strCondition)
{
List <clsvQuestionnaire_SimEN> arrObjLst = clsvQuestionnaire_SimBL.GetObjLst(strCondition);
List <clsvQuestionnaire_SimENEx> arrObjExLst = new List<clsvQuestionnaire_SimENEx>();
foreach (clsvQuestionnaire_SimEN objInFor in arrObjLst)
{
clsvQuestionnaire_SimENEx objvQuestionnaire_SimENEx = new clsvQuestionnaire_SimENEx();
clsvQuestionnaire_SimBL.CopyTo(objInFor, objvQuestionnaire_SimENEx);
arrObjExLst.Add(objvQuestionnaire_SimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvQuestionnaire_SimENEx GetObjExByQuestionID(long strQuestionId)
{
clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = clsvQuestionnaire_SimBL.GetObjByQuestionId(strQuestionId);
clsvQuestionnaire_SimENEx objvQuestionnaire_SimENEx = new clsvQuestionnaire_SimENEx();
clsvQuestionnaire_SimBL.CopyTo(objvQuestionnaire_SimEN, objvQuestionnaire_SimENEx);
return objvQuestionnaire_SimENEx;
}
}
}