
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire4App_TBLEx
 表名:vQuestionnaire4App_T(01120222)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx,0021)
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
 public class RelatedActions_vQuestionnaire4App_TEx: RelatedActions_vQuestionnaire4App_T
{
public override bool UpdRelaTabDate(long lngQuestionId, string strOpUser)
{
return true;
}
}
public static class  clsvQuestionnaire4App_TBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire4App_TEN:objvQuestionnaire4App_TENT</returns>
 public static clsvQuestionnaire4App_TENEx CopyToEx(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENS)
{
try
{
 clsvQuestionnaire4App_TENEx objvQuestionnaire4App_TENT = new clsvQuestionnaire4App_TENEx();
clsvQuestionnaire4App_TBL.vQuestionnaire4App_TDA.CopyTo(objvQuestionnaire4App_TENS, objvQuestionnaire4App_TENT);
 return objvQuestionnaire4App_TENT;
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
 /// <param name = "objvQuestionnaire4App_TENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire4App_TEN:objvQuestionnaire4App_TENT</returns>
 public static clsvQuestionnaire4App_TEN CopyTo(this clsvQuestionnaire4App_TENEx objvQuestionnaire4App_TENS)
{
try
{
 clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENT = new clsvQuestionnaire4App_TEN();
clsvQuestionnaire4App_TBL.CopyTo(objvQuestionnaire4App_TENS, objvQuestionnaire4App_TENT);
 return objvQuestionnaire4App_TENT;
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
 /// v题目表4App_T(vQuestionnaire4App_T)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsvQuestionnaire4App_TBLEx : clsvQuestionnaire4App_TBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvQuestionnaire4App_TDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvQuestionnaire4App_TDAEx vQuestionnaire4App_TDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvQuestionnaire4App_TDAEx();
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
public static List<clsvQuestionnaire4App_TENEx> GetObjExLst(string strCondition)
{
List <clsvQuestionnaire4App_TEN> arrObjLst = clsvQuestionnaire4App_TBL.GetObjLst(strCondition);
List <clsvQuestionnaire4App_TENEx> arrObjExLst = new List<clsvQuestionnaire4App_TENEx>();
foreach (clsvQuestionnaire4App_TEN objInFor in arrObjLst)
{
clsvQuestionnaire4App_TENEx objvQuestionnaire4App_TENEx = new clsvQuestionnaire4App_TENEx();
clsvQuestionnaire4App_TBL.CopyTo(objInFor, objvQuestionnaire4App_TENEx);
arrObjExLst.Add(objvQuestionnaire4App_TENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvQuestionnaire4App_TENEx GetObjExByQuestionId(long lngQuestionId)
{
clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = clsvQuestionnaire4App_TBL.GetObjByQuestionId(lngQuestionId);
clsvQuestionnaire4App_TENEx objvQuestionnaire4App_TENEx = new clsvQuestionnaire4App_TENEx();
clsvQuestionnaire4App_TBL.CopyTo(objvQuestionnaire4App_TEN, objvQuestionnaire4App_TENEx);
return objvQuestionnaire4App_TENEx;
}
}
}