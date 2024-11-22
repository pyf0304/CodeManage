
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_QuestionsTypeBLEx
 表名:qa_QuestionsType(01120752)
 生成代码版本:2020.09.24.1
 生成日期:2020/10/13 19:24:26
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsqa_QuestionsTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeENS">源对象</param>
 /// <returns>目标对象=>clsqa_QuestionsTypeEN:objqa_QuestionsTypeENT</returns>
 public static clsqa_QuestionsTypeENEx CopyToEx(this clsqa_QuestionsTypeEN objqa_QuestionsTypeENS)
{
try
{
 clsqa_QuestionsTypeENEx objqa_QuestionsTypeENT = new clsqa_QuestionsTypeENEx();
clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.CopyTo(objqa_QuestionsTypeENS, objqa_QuestionsTypeENT);
 return objqa_QuestionsTypeENT;
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
 /// <param name = "objqa_QuestionsTypeENS">源对象</param>
 /// <returns>目标对象=>clsqa_QuestionsTypeEN:objqa_QuestionsTypeENT</returns>
 public static clsqa_QuestionsTypeEN CopyTo(this clsqa_QuestionsTypeENEx objqa_QuestionsTypeENS)
{
try
{
 clsqa_QuestionsTypeEN objqa_QuestionsTypeENT = new clsqa_QuestionsTypeEN();
clsqa_QuestionsTypeBL.CopyTo(objqa_QuestionsTypeENS, objqa_QuestionsTypeENT);
 return objqa_QuestionsTypeENT;
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
 /// 问题类型表(qa_QuestionsType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsqa_QuestionsTypeBLEx : clsqa_QuestionsTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsqa_QuestionsTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsqa_QuestionsTypeDAEx qa_QuestionsTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsqa_QuestionsTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objqa_QuestionsTypeENS">源对象</param>
 /// <returns>目标对象=>clsqa_QuestionsTypeEN:objqa_QuestionsTypeENT</returns>
 public static clsqa_QuestionsTypeENEx CopyToEx(clsqa_QuestionsTypeEN objqa_QuestionsTypeENS)
{
try
{
 clsqa_QuestionsTypeENEx objqa_QuestionsTypeENT = new clsqa_QuestionsTypeENEx();
clsqa_QuestionsTypeBL.qa_QuestionsTypeDA.CopyTo(objqa_QuestionsTypeENS, objqa_QuestionsTypeENT);
 return objqa_QuestionsTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
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
public static List<clsqa_QuestionsTypeENEx> GetObjExLst(string strCondition)
{
List <clsqa_QuestionsTypeEN> arrObjLst = clsqa_QuestionsTypeBL.GetObjLst(strCondition);
List <clsqa_QuestionsTypeENEx> arrObjExLst = new List<clsqa_QuestionsTypeENEx>();
foreach (clsqa_QuestionsTypeEN objInFor in arrObjLst)
{
clsqa_QuestionsTypeENEx objqa_QuestionsTypeENEx = new clsqa_QuestionsTypeENEx();
clsqa_QuestionsTypeBL.CopyTo(objInFor, objqa_QuestionsTypeENEx);
arrObjExLst.Add(objqa_QuestionsTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strQuestionsTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsqa_QuestionsTypeENEx GetObjExByQuestionsTypeId(string strQuestionsTypeId)
{
clsqa_QuestionsTypeEN objqa_QuestionsTypeEN = clsqa_QuestionsTypeBL.GetObjByQuestionsTypeId(strQuestionsTypeId);
clsqa_QuestionsTypeENEx objqa_QuestionsTypeENEx = new clsqa_QuestionsTypeENEx();
clsqa_QuestionsTypeBL.CopyTo(objqa_QuestionsTypeEN, objqa_QuestionsTypeENEx);
return objqa_QuestionsTypeENEx;
}
}
}