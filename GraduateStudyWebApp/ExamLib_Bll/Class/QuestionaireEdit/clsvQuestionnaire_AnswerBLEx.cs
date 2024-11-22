
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_AnswerBLEx
 表名:vQuestionnaire_Answer(01120020)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 18:51:19
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护
 模块英文名:QuestionaireEdit
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
public static class clsvQuestionnaire_AnswerBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire_AnswerEN:objvQuestionnaire_AnswerENT</returns>
 public static clsvQuestionnaire_AnswerENEx CopyToEx(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENS)
{
try
{
 clsvQuestionnaire_AnswerENEx objvQuestionnaire_AnswerENT = new clsvQuestionnaire_AnswerENEx();
clsvQuestionnaire_AnswerBL.vQuestionnaire_AnswerDA.CopyTo(objvQuestionnaire_AnswerENS, objvQuestionnaire_AnswerENT);
 return objvQuestionnaire_AnswerENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire_AnswerEN:objvQuestionnaire_AnswerENT</returns>
 public static clsvQuestionnaire_AnswerEN CopyTo(this clsvQuestionnaire_AnswerENEx objvQuestionnaire_AnswerENS)
{
try
{
 clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENT = new clsvQuestionnaire_AnswerEN();
clsvQuestionnaire_AnswerBL.CopyTo(objvQuestionnaire_AnswerENS, objvQuestionnaire_AnswerENT);
 return objvQuestionnaire_AnswerENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// vQuestionnaire_Answer(vQuestionnaire_Answer)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvQuestionnaire_AnswerBLEx : clsvQuestionnaire_AnswerBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvQuestionnaire_AnswerDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvQuestionnaire_AnswerDAEx vQuestionnaire_AnswerDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvQuestionnaire_AnswerDAEx();
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
public static List<clsvQuestionnaire_AnswerENEx> GetObjExLst(string strCondition)
{
List <clsvQuestionnaire_AnswerEN> arrObjLst = clsvQuestionnaire_AnswerBL.GetObjLst(strCondition);
List <clsvQuestionnaire_AnswerENEx> arrObjExLst = new List<clsvQuestionnaire_AnswerENEx>();
foreach (clsvQuestionnaire_AnswerEN objInFor in arrObjLst)
{
clsvQuestionnaire_AnswerENEx objvQuestionnaire_AnswerENEx = new clsvQuestionnaire_AnswerENEx();
clsvQuestionnaire_AnswerBL.CopyTo(objInFor, objvQuestionnaire_AnswerENEx);
arrObjExLst.Add(objvQuestionnaire_AnswerENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strQuestionId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvQuestionnaire_AnswerENEx GetObjExByQuestionId(long strQuestionId)
{
clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = clsvQuestionnaire_AnswerBL.GetObjByQuestionId(strQuestionId);
clsvQuestionnaire_AnswerENEx objvQuestionnaire_AnswerENEx = new clsvQuestionnaire_AnswerENEx();
clsvQuestionnaire_AnswerBL.CopyTo(objvQuestionnaire_AnswerEN, objvQuestionnaire_AnswerENEx);
return objvQuestionnaire_AnswerENEx;
}
}
}