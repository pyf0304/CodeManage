
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireSetBLEx
 表名:QuestionnaireSet(01120007)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 17:32:40
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
public static class clsQuestionnaireSetBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objQuestionnaireSetENS">源对象</param>
 /// <returns>目标对象=>clsQuestionnaireSetEN:objQuestionnaireSetENT</returns>
 public static clsQuestionnaireSetENEx CopyToEx(this clsQuestionnaireSetEN objQuestionnaireSetENS)
{
try
{
 clsQuestionnaireSetENEx objQuestionnaireSetENT = new clsQuestionnaireSetENEx();
clsQuestionnaireSetBL.QuestionnaireSetDA.CopyTo(objQuestionnaireSetENS, objQuestionnaireSetENT);
 return objQuestionnaireSetENT;
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
 /// <param name = "objQuestionnaireSetENS">源对象</param>
 /// <returns>目标对象=>clsQuestionnaireSetEN:objQuestionnaireSetENT</returns>
 public static clsQuestionnaireSetEN CopyTo(this clsQuestionnaireSetENEx objQuestionnaireSetENS)
{
try
{
 clsQuestionnaireSetEN objQuestionnaireSetENT = new clsQuestionnaireSetEN();
clsQuestionnaireSetBL.CopyTo(objQuestionnaireSetENS, objQuestionnaireSetENT);
 return objQuestionnaireSetENT;
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
 /// 问卷集(QuestionnaireSet)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsQuestionnaireSetBLEx : clsQuestionnaireSetBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsQuestionnaireSetDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsQuestionnaireSetDAEx QuestionnaireSetDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsQuestionnaireSetDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objQuestionnaireSetENS">源对象</param>
 /// <returns>目标对象=>clsQuestionnaireSetEN:objQuestionnaireSetENT</returns>
 public static clsQuestionnaireSetENEx CopyToEx(clsQuestionnaireSetEN objQuestionnaireSetENS)
{
try
{
 clsQuestionnaireSetENEx objQuestionnaireSetENT = new clsQuestionnaireSetENEx();
clsQuestionnaireSetBL.QuestionnaireSetDA.CopyTo(objQuestionnaireSetENS, objQuestionnaireSetENT);
 return objQuestionnaireSetENT;
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
public static List<clsQuestionnaireSetENEx> GetObjExLst(string strCondition)
{
List <clsQuestionnaireSetEN> arrObjLst = clsQuestionnaireSetBL.GetObjLst(strCondition);
List <clsQuestionnaireSetENEx> arrObjExLst = new List<clsQuestionnaireSetENEx>();
foreach (clsQuestionnaireSetEN objInFor in arrObjLst)
{
clsQuestionnaireSetENEx objQuestionnaireSetENEx = new clsQuestionnaireSetENEx();
clsQuestionnaireSetBL.CopyTo(objInFor, objQuestionnaireSetENEx);
arrObjExLst.Add(objQuestionnaireSetENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsQuestionnaireSetENEx GetObjExByQuestionnaireSetId(string strQuestionnaireSetId)
{
clsQuestionnaireSetEN objQuestionnaireSetEN = clsQuestionnaireSetBL.GetObjByQuestionnaireSetId(strQuestionnaireSetId);
clsQuestionnaireSetENEx objQuestionnaireSetENEx = new clsQuestionnaireSetENEx();
clsQuestionnaireSetBL.CopyTo(objQuestionnaireSetEN, objQuestionnaireSetENEx);
return objQuestionnaireSetENEx;
}
}
}