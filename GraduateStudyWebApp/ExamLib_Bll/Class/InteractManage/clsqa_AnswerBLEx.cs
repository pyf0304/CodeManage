
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_AnswerBLEx
 表名:qa_Answer(01120641)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/12 21:49:54
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
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
public static class clsqa_AnswerBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objqa_AnswerENS">源对象</param>
 /// <returns>目标对象=>clsqa_AnswerEN:objqa_AnswerENT</returns>
 public static clsqa_AnswerENEx CopyToEx(this clsqa_AnswerEN objqa_AnswerENS)
{
try
{
 clsqa_AnswerENEx objqa_AnswerENT = new clsqa_AnswerENEx();
clsqa_AnswerBL.qa_AnswerDA.CopyTo(objqa_AnswerENS, objqa_AnswerENT);
 return objqa_AnswerENT;
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
 /// <param name = "objqa_AnswerENS">源对象</param>
 /// <returns>目标对象=>clsqa_AnswerEN:objqa_AnswerENT</returns>
 public static clsqa_AnswerEN CopyTo(this clsqa_AnswerENEx objqa_AnswerENS)
{
try
{
 clsqa_AnswerEN objqa_AnswerENT = new clsqa_AnswerEN();
clsqa_AnswerBL.CopyTo(objqa_AnswerENS, objqa_AnswerENT);
 return objqa_AnswerENT;
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
 /// 答疑回答(qa_Answer)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsqa_AnswerBLEx : clsqa_AnswerBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsqa_AnswerDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsqa_AnswerDAEx qa_AnswerDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsqa_AnswerDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objqa_AnswerENS">源对象</param>
 /// <returns>目标对象=>clsqa_AnswerEN:objqa_AnswerENT</returns>
 public static clsqa_AnswerENEx CopyToEx(clsqa_AnswerEN objqa_AnswerENS)
{
try
{
 clsqa_AnswerENEx objqa_AnswerENT = new clsqa_AnswerENEx();
clsqa_AnswerBL.qa_AnswerDA.CopyTo(objqa_AnswerENS, objqa_AnswerENT);
 return objqa_AnswerENT;
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
public static List<clsqa_AnswerENEx> GetObjExLst(string strCondition)
{
List <clsqa_AnswerEN> arrObjLst = clsqa_AnswerBL.GetObjLst(strCondition);
List <clsqa_AnswerENEx> arrObjExLst = new List<clsqa_AnswerENEx>();
foreach (clsqa_AnswerEN objInFor in arrObjLst)
{
clsqa_AnswerENEx objqa_AnswerENEx = new clsqa_AnswerENEx();
clsqa_AnswerBL.CopyTo(objInFor, objqa_AnswerENEx);
arrObjExLst.Add(objqa_AnswerENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsqa_AnswerENEx GetObjExByAnswerId(string strAnswerId)
{
clsqa_AnswerEN objqa_AnswerEN = clsqa_AnswerBL.GetObjByAnswerId(strAnswerId);
clsqa_AnswerENEx objqa_AnswerENEx = new clsqa_AnswerENEx();
clsqa_AnswerBL.CopyTo(objqa_AnswerEN, objqa_AnswerENEx);
return objqa_AnswerENEx;
}
}
}