
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionNumByKnowledgeIdBLEx
 表名:vQuestionNumByKnowledgeId(01120937)
 生成代码版本:2022.11.19.1
 生成日期:2022/11/20 02:41:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 public class RelatedActions_vQuestionNumByKnowledgeIdEx: RelatedActions_vQuestionNumByKnowledgeId
{
public override bool UpdRelaTabDate(string strCourseKnowledgeId, string strOpUser)
{
return true;
}
}
public static class clsvQuestionNumByKnowledgeIdBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvQuestionNumByKnowledgeIdENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionNumByKnowledgeIdEN:objvQuestionNumByKnowledgeIdENT</returns>
 public static clsvQuestionNumByKnowledgeIdENEx CopyToEx(this clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdENS)
{
try
{
 clsvQuestionNumByKnowledgeIdENEx objvQuestionNumByKnowledgeIdENT = new clsvQuestionNumByKnowledgeIdENEx();
clsvQuestionNumByKnowledgeIdBL.vQuestionNumByKnowledgeIdDA.CopyTo(objvQuestionNumByKnowledgeIdENS, objvQuestionNumByKnowledgeIdENT);
 return objvQuestionNumByKnowledgeIdENT;
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
 /// <param name = "objvQuestionNumByKnowledgeIdENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionNumByKnowledgeIdEN:objvQuestionNumByKnowledgeIdENT</returns>
 public static clsvQuestionNumByKnowledgeIdEN CopyTo(this clsvQuestionNumByKnowledgeIdENEx objvQuestionNumByKnowledgeIdENS)
{
try
{
 clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdENT = new clsvQuestionNumByKnowledgeIdEN();
clsvQuestionNumByKnowledgeIdBL.CopyTo(objvQuestionNumByKnowledgeIdENS, objvQuestionNumByKnowledgeIdENT);
 return objvQuestionNumByKnowledgeIdENT;
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
 /// vQuestionNumByKnowledgeId(vQuestionNumByKnowledgeId)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvQuestionNumByKnowledgeIdBLEx : clsvQuestionNumByKnowledgeIdBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvQuestionNumByKnowledgeIdDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvQuestionNumByKnowledgeIdDAEx vQuestionNumByKnowledgeIdDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvQuestionNumByKnowledgeIdDAEx();
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
public static List<clsvQuestionNumByKnowledgeIdENEx> GetObjExLst(string strCondition)
{
List <clsvQuestionNumByKnowledgeIdEN> arrObjLst = clsvQuestionNumByKnowledgeIdBL.GetObjLst(strCondition);
List <clsvQuestionNumByKnowledgeIdENEx> arrObjExLst = new List<clsvQuestionNumByKnowledgeIdENEx>();
foreach (clsvQuestionNumByKnowledgeIdEN objInFor in arrObjLst)
{
clsvQuestionNumByKnowledgeIdENEx objvQuestionNumByKnowledgeIdENEx = new clsvQuestionNumByKnowledgeIdENEx();
clsvQuestionNumByKnowledgeIdBL.CopyTo(objInFor, objvQuestionNumByKnowledgeIdENEx);
arrObjExLst.Add(objvQuestionNumByKnowledgeIdENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvQuestionNumByKnowledgeIdENEx GetObjExByCourseKnowledgeId(string strCourseKnowledgeId)
{
clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = clsvQuestionNumByKnowledgeIdBL.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
clsvQuestionNumByKnowledgeIdENEx objvQuestionNumByKnowledgeIdENEx = new clsvQuestionNumByKnowledgeIdENEx();
clsvQuestionNumByKnowledgeIdBL.CopyTo(objvQuestionNumByKnowledgeIdEN, objvQuestionNumByKnowledgeIdENEx);
return objvQuestionNumByKnowledgeIdENEx;
}
}
}