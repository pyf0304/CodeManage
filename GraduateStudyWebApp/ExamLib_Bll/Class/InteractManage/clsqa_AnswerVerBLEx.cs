
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_AnswerVerBLEx
 表名:qa_AnswerVer(01120756)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 日期:2023/01/12 15:19:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 public class RelatedActions_qa_AnswerVerEx: RelatedActions_qa_AnswerVer
{
public override bool UpdRelaTabDate(long lngAnswerVId, string strOpUser)
{
return true;
}
}
public static class clsqa_AnswerVerBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objqa_AnswerVerENS">源对象</param>
 /// <returns>目标对象=>clsqa_AnswerVerEN:objqa_AnswerVerENT</returns>
 public static clsqa_AnswerVerENEx CopyToEx(this clsqa_AnswerVerEN objqa_AnswerVerENS)
{
try
{
 clsqa_AnswerVerENEx objqa_AnswerVerENT = new clsqa_AnswerVerENEx();
clsqa_AnswerVerBL.qa_AnswerVerDA.CopyTo(objqa_AnswerVerENS, objqa_AnswerVerENT);
 return objqa_AnswerVerENT;
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
 /// <param name = "objqa_AnswerVerENS">源对象</param>
 /// <returns>目标对象=>clsqa_AnswerVerEN:objqa_AnswerVerENT</returns>
 public static clsqa_AnswerVerEN CopyTo(this clsqa_AnswerVerENEx objqa_AnswerVerENS)
{
try
{
 clsqa_AnswerVerEN objqa_AnswerVerENT = new clsqa_AnswerVerEN();
clsqa_AnswerVerBL.CopyTo(objqa_AnswerVerENS, objqa_AnswerVerENT);
 return objqa_AnswerVerENT;
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
 /// 答疑回答历史V(qa_AnswerVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsqa_AnswerVerBLEx : clsqa_AnswerVerBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsqa_AnswerVerDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsqa_AnswerVerDAEx qa_AnswerVerDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsqa_AnswerVerDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objqa_AnswerVerENS">源对象</param>
 /// <returns>目标对象=>clsqa_AnswerVerEN:objqa_AnswerVerENT</returns>
 public static clsqa_AnswerVerENEx CopyToEx(clsqa_AnswerVerEN objqa_AnswerVerENS)
{
try
{
 clsqa_AnswerVerENEx objqa_AnswerVerENT = new clsqa_AnswerVerENEx();
clsqa_AnswerVerBL.qa_AnswerVerDA.CopyTo(objqa_AnswerVerENS, objqa_AnswerVerENT);
 return objqa_AnswerVerENT;
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
public static List<clsqa_AnswerVerENEx> GetObjExLst(string strCondition)
{
List <clsqa_AnswerVerEN> arrObjLst = clsqa_AnswerVerBL.GetObjLst(strCondition);
List <clsqa_AnswerVerENEx> arrObjExLst = new List<clsqa_AnswerVerENEx>();
foreach (clsqa_AnswerVerEN objInFor in arrObjLst)
{
clsqa_AnswerVerENEx objqa_AnswerVerENEx = new clsqa_AnswerVerENEx();
clsqa_AnswerVerBL.CopyTo(objInFor, objqa_AnswerVerENEx);
arrObjExLst.Add(objqa_AnswerVerENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngAnswerVId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsqa_AnswerVerENEx GetObjExByAnswerVId(long lngAnswerVId)
{
clsqa_AnswerVerEN objqa_AnswerVerEN = clsqa_AnswerVerBL.GetObjByAnswerVId(lngAnswerVId);
clsqa_AnswerVerENEx objqa_AnswerVerENEx = new clsqa_AnswerVerENEx();
clsqa_AnswerVerBL.CopyTo(objqa_AnswerVerEN, objqa_AnswerVerENEx);
return objqa_AnswerVerENEx;
}
}
}