
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionMarkStatusBLEx
 表名:QuestionMarkStatus(01120215)
 生成代码版本:2021.06.20.1
 生成日期:2021/06/26 15:49:58
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计
 模块英文名:QueryStatistics
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
public static class clsQuestionMarkStatusBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objQuestionMarkStatusENS">源对象</param>
 /// <returns>目标对象=>clsQuestionMarkStatusEN:objQuestionMarkStatusENT</returns>
 public static clsQuestionMarkStatusENEx CopyToEx(this clsQuestionMarkStatusEN objQuestionMarkStatusENS)
{
try
{
 clsQuestionMarkStatusENEx objQuestionMarkStatusENT = new clsQuestionMarkStatusENEx();
clsQuestionMarkStatusBL.QuestionMarkStatusDA.CopyTo(objQuestionMarkStatusENS, objQuestionMarkStatusENT);
 return objQuestionMarkStatusENT;
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
 /// <param name = "objQuestionMarkStatusENS">源对象</param>
 /// <returns>目标对象=>clsQuestionMarkStatusEN:objQuestionMarkStatusENT</returns>
 public static clsQuestionMarkStatusEN CopyTo(this clsQuestionMarkStatusENEx objQuestionMarkStatusENS)
{
try
{
 clsQuestionMarkStatusEN objQuestionMarkStatusENT = new clsQuestionMarkStatusEN();
clsQuestionMarkStatusBL.CopyTo(objQuestionMarkStatusENS, objQuestionMarkStatusENT);
 return objQuestionMarkStatusENT;
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
 /// 题目打分状态(QuestionMarkStatus)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsQuestionMarkStatusBLEx : clsQuestionMarkStatusBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsQuestionMarkStatusDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsQuestionMarkStatusDAEx QuestionMarkStatusDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsQuestionMarkStatusDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objQuestionMarkStatusENS">源对象</param>
 /// <returns>目标对象=>clsQuestionMarkStatusEN:objQuestionMarkStatusENT</returns>
 public static clsQuestionMarkStatusENEx CopyToEx(clsQuestionMarkStatusEN objQuestionMarkStatusENS)
{
try
{
 clsQuestionMarkStatusENEx objQuestionMarkStatusENT = new clsQuestionMarkStatusENEx();
clsQuestionMarkStatusBL.QuestionMarkStatusDA.CopyTo(objQuestionMarkStatusENS, objQuestionMarkStatusENT);
 return objQuestionMarkStatusENT;
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
public static List<clsQuestionMarkStatusENEx> GetObjExLst(string strCondition)
{
List <clsQuestionMarkStatusEN> arrObjLst = clsQuestionMarkStatusBL.GetObjLst(strCondition);
List <clsQuestionMarkStatusENEx> arrObjExLst = new List<clsQuestionMarkStatusENEx>();
foreach (clsQuestionMarkStatusEN objInFor in arrObjLst)
{
clsQuestionMarkStatusENEx objQuestionMarkStatusENEx = new clsQuestionMarkStatusENEx();
clsQuestionMarkStatusBL.CopyTo(objInFor, objQuestionMarkStatusENEx);
arrObjExLst.Add(objQuestionMarkStatusENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "stridCurrEduCls">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsQuestionMarkStatusENEx GetObjExByidCurrEduCls(string stridCurrEduCls)
{
clsQuestionMarkStatusEN objQuestionMarkStatusEN = clsQuestionMarkStatusBL.GetObjByIdCurrEduCls(stridCurrEduCls);
clsQuestionMarkStatusENEx objQuestionMarkStatusENEx = new clsQuestionMarkStatusENEx();
clsQuestionMarkStatusBL.CopyTo(objQuestionMarkStatusEN, objQuestionMarkStatusENEx);
return objQuestionMarkStatusENEx;
}
}
}