
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_KnowledgeBLEx
 表名:vQuestionnaire_Knowledge(01120143)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 18:51:12
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
public static class clsvQuestionnaire_KnowledgeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire_KnowledgeEN:objvQuestionnaire_KnowledgeENT</returns>
 public static clsvQuestionnaire_KnowledgeENEx CopyToEx(this clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENS)
{
try
{
 clsvQuestionnaire_KnowledgeENEx objvQuestionnaire_KnowledgeENT = new clsvQuestionnaire_KnowledgeENEx();
clsvQuestionnaire_KnowledgeBL.vQuestionnaire_KnowledgeDA.CopyTo(objvQuestionnaire_KnowledgeENS, objvQuestionnaire_KnowledgeENT);
 return objvQuestionnaire_KnowledgeENT;
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
 /// <param name = "objvQuestionnaire_KnowledgeENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire_KnowledgeEN:objvQuestionnaire_KnowledgeENT</returns>
 public static clsvQuestionnaire_KnowledgeEN CopyTo(this clsvQuestionnaire_KnowledgeENEx objvQuestionnaire_KnowledgeENS)
{
try
{
 clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENT = new clsvQuestionnaire_KnowledgeEN();
clsvQuestionnaire_KnowledgeBL.CopyTo(objvQuestionnaire_KnowledgeENS, objvQuestionnaire_KnowledgeENT);
 return objvQuestionnaire_KnowledgeENT;
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
 /// v题目表_知识点(vQuestionnaire_Knowledge)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvQuestionnaire_KnowledgeBLEx : clsvQuestionnaire_KnowledgeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvQuestionnaire_KnowledgeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvQuestionnaire_KnowledgeDAEx vQuestionnaire_KnowledgeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvQuestionnaire_KnowledgeDAEx();
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
public static List<clsvQuestionnaire_KnowledgeENEx> GetObjExLst(string strCondition)
{
List <clsvQuestionnaire_KnowledgeEN> arrObjLst = clsvQuestionnaire_KnowledgeBL.GetObjLst(strCondition);
List <clsvQuestionnaire_KnowledgeENEx> arrObjExLst = new List<clsvQuestionnaire_KnowledgeENEx>();
foreach (clsvQuestionnaire_KnowledgeEN objInFor in arrObjLst)
{
clsvQuestionnaire_KnowledgeENEx objvQuestionnaire_KnowledgeENEx = new clsvQuestionnaire_KnowledgeENEx();
clsvQuestionnaire_KnowledgeBL.CopyTo(objInFor, objvQuestionnaire_KnowledgeENEx);
arrObjExLst.Add(objvQuestionnaire_KnowledgeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strQuestionId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvQuestionnaire_KnowledgeENEx GetObjExByQuestionId(long strQuestionId)
{
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = clsvQuestionnaire_KnowledgeBL.GetObjByQuestionId(strQuestionId);
clsvQuestionnaire_KnowledgeENEx objvQuestionnaire_KnowledgeENEx = new clsvQuestionnaire_KnowledgeENEx();
clsvQuestionnaire_KnowledgeBL.CopyTo(objvQuestionnaire_KnowledgeEN, objvQuestionnaire_KnowledgeENEx);
return objvQuestionnaire_KnowledgeENEx;
}
}
}