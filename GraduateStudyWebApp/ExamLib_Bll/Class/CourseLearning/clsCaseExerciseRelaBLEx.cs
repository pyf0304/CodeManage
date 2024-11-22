
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseExerciseRelaBLEx
 表名:CaseExerciseRela(01120437)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 17:23:25
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsCaseExerciseRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objCaseExerciseRelaENS">源对象</param>
 /// <returns>目标对象=>clsCaseExerciseRelaEN:objCaseExerciseRelaENT</returns>
 public static clsCaseExerciseRelaENEx CopyToEx(this clsCaseExerciseRelaEN objCaseExerciseRelaENS)
{
try
{
 clsCaseExerciseRelaENEx objCaseExerciseRelaENT = new clsCaseExerciseRelaENEx();
clsCaseExerciseRelaBL.CaseExerciseRelaDA.CopyTo(objCaseExerciseRelaENS, objCaseExerciseRelaENT);
 return objCaseExerciseRelaENT;
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
 /// <param name = "objCaseExerciseRelaENS">源对象</param>
 /// <returns>目标对象=>clsCaseExerciseRelaEN:objCaseExerciseRelaENT</returns>
 public static clsCaseExerciseRelaEN CopyTo(this clsCaseExerciseRelaENEx objCaseExerciseRelaENS)
{
try
{
 clsCaseExerciseRelaEN objCaseExerciseRelaENT = new clsCaseExerciseRelaEN();
clsCaseExerciseRelaBL.CopyTo(objCaseExerciseRelaENS, objCaseExerciseRelaENT);
 return objCaseExerciseRelaENT;
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
 /// 案例习题关系(CaseExerciseRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsCaseExerciseRelaBLEx : clsCaseExerciseRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsCaseExerciseRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsCaseExerciseRelaDAEx CaseExerciseRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsCaseExerciseRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objCaseExerciseRelaENS">源对象</param>
 /// <returns>目标对象=>clsCaseExerciseRelaEN:objCaseExerciseRelaENT</returns>
 public static clsCaseExerciseRelaENEx CopyToEx(clsCaseExerciseRelaEN objCaseExerciseRelaENS)
{
try
{
 clsCaseExerciseRelaENEx objCaseExerciseRelaENT = new clsCaseExerciseRelaENEx();
clsCaseExerciseRelaBL.CaseExerciseRelaDA.CopyTo(objCaseExerciseRelaENS, objCaseExerciseRelaENT);
 return objCaseExerciseRelaENT;
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
public static List<clsCaseExerciseRelaENEx> GetObjExLst(string strCondition)
{
List <clsCaseExerciseRelaEN> arrObjLst = clsCaseExerciseRelaBL.GetObjLst(strCondition);
List <clsCaseExerciseRelaENEx> arrObjExLst = new List<clsCaseExerciseRelaENEx>();
foreach (clsCaseExerciseRelaEN objInFor in arrObjLst)
{
clsCaseExerciseRelaENEx objCaseExerciseRelaENEx = new clsCaseExerciseRelaENEx();
clsCaseExerciseRelaBL.CopyTo(objInFor, objCaseExerciseRelaENEx);
arrObjExLst.Add(objCaseExerciseRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngid_CaseExerciseRela">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsCaseExerciseRelaENEx GetObjExByid_CaseExerciseRela(long lngid_CaseExerciseRela)
{
clsCaseExerciseRelaEN objCaseExerciseRelaEN = clsCaseExerciseRelaBL.GetObjByIdCaseExerciseRela(lngid_CaseExerciseRela);
clsCaseExerciseRelaENEx objCaseExerciseRelaENEx = new clsCaseExerciseRelaENEx();
clsCaseExerciseRelaBL.CopyTo(objCaseExerciseRelaEN, objCaseExerciseRelaENEx);
return objCaseExerciseRelaENEx;
}
}
}