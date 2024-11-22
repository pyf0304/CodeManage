
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserAnswerResult_TtlBLEx
 表名:vUserAnswerResult_Ttl(01120023)
 * 版本:2023.07.28.1(服务器:WIN-SRV103-116)
 日期:2023/08/13 05:31:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷结果(QuestionnaireResult)
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
 public class RelatedActions_vUserAnswerResult_TtlEx: RelatedActions_vUserAnswerResult_Ttl
{
public override bool UpdRelaTabDate(string strQuestionID, string strOpUser)
{
return true;
}
}
public static class  clsvUserAnswerResult_TtlBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvUserAnswerResult_TtlENS">源对象</param>
 /// <returns>目标对象=>clsvUserAnswerResult_TtlEN:objvUserAnswerResult_TtlENT</returns>
 public static clsvUserAnswerResult_TtlENEx CopyToEx(this clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlENS)
{
try
{
 clsvUserAnswerResult_TtlENEx objvUserAnswerResult_TtlENT = new clsvUserAnswerResult_TtlENEx();
clsvUserAnswerResult_TtlBL.vUserAnswerResult_TtlDA.CopyTo(objvUserAnswerResult_TtlENS, objvUserAnswerResult_TtlENT);
 return objvUserAnswerResult_TtlENT;
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
 /// <param name = "objvUserAnswerResult_TtlENS">源对象</param>
 /// <returns>目标对象=>clsvUserAnswerResult_TtlEN:objvUserAnswerResult_TtlENT</returns>
 public static clsvUserAnswerResult_TtlEN CopyTo(this clsvUserAnswerResult_TtlENEx objvUserAnswerResult_TtlENS)
{
try
{
 clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlENT = new clsvUserAnswerResult_TtlEN();
clsvUserAnswerResult_TtlBL.CopyTo(objvUserAnswerResult_TtlENS, objvUserAnswerResult_TtlENT);
 return objvUserAnswerResult_TtlENT;
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
 /// v用户问卷结果_Ttl(vUserAnswerResult_Ttl)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsvUserAnswerResult_TtlBLEx : clsvUserAnswerResult_TtlBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvUserAnswerResult_TtlDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvUserAnswerResult_TtlDAEx vUserAnswerResult_TtlDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvUserAnswerResult_TtlDAEx();
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
public static List<clsvUserAnswerResult_TtlENEx> GetObjExLst(string strCondition)
{
List <clsvUserAnswerResult_TtlEN> arrObjLst = clsvUserAnswerResult_TtlBL.GetObjLst(strCondition);
List <clsvUserAnswerResult_TtlENEx> arrObjExLst = new List<clsvUserAnswerResult_TtlENEx>();
foreach (clsvUserAnswerResult_TtlEN objInFor in arrObjLst)
{
clsvUserAnswerResult_TtlENEx objvUserAnswerResult_TtlENEx = new clsvUserAnswerResult_TtlENEx();
clsvUserAnswerResult_TtlBL.CopyTo(objInFor, objvUserAnswerResult_TtlENEx);
arrObjExLst.Add(objvUserAnswerResult_TtlENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvUserAnswerResult_TtlENEx GetObjExByQuestionID(string strQuestionID)
{
clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = clsvUserAnswerResult_TtlBL.GetObjByQuestionID(strQuestionID);
clsvUserAnswerResult_TtlENEx objvUserAnswerResult_TtlENEx = new clsvUserAnswerResult_TtlENEx();
clsvUserAnswerResult_TtlBL.CopyTo(objvUserAnswerResult_TtlEN, objvUserAnswerResult_TtlENEx);
return objvUserAnswerResult_TtlENEx;
}
}
}