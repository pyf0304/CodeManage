
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamGradeBLEx
 表名:cc_ExamGrade(01120070)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:48:38
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clscc_ExamGradeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_ExamGradeENS">源对象</param>
 /// <returns>目标对象=>clscc_ExamGradeEN:objcc_ExamGradeENT</returns>
 public static clscc_ExamGradeENEx CopyToEx(this clscc_ExamGradeEN objcc_ExamGradeENS)
{
try
{
 clscc_ExamGradeENEx objcc_ExamGradeENT = new clscc_ExamGradeENEx();
clscc_ExamGradeBL.cc_ExamGradeDA.CopyTo(objcc_ExamGradeENS, objcc_ExamGradeENT);
 return objcc_ExamGradeENT;
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
 /// <param name = "objcc_ExamGradeENS">源对象</param>
 /// <returns>目标对象=>clscc_ExamGradeEN:objcc_ExamGradeENT</returns>
 public static clscc_ExamGradeEN CopyTo(this clscc_ExamGradeENEx objcc_ExamGradeENS)
{
try
{
 clscc_ExamGradeEN objcc_ExamGradeENT = new clscc_ExamGradeEN();
clscc_ExamGradeBL.CopyTo(objcc_ExamGradeENS, objcc_ExamGradeENT);
 return objcc_ExamGradeENT;
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
 /// 题库等级(cc_ExamGrade)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_ExamGradeBLEx : clscc_ExamGradeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_ExamGradeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_ExamGradeDAEx cc_ExamGradeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_ExamGradeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_ExamGradeENS">源对象</param>
 /// <returns>目标对象=>clscc_ExamGradeEN:objcc_ExamGradeENT</returns>
 public static clscc_ExamGradeENEx CopyToEx(clscc_ExamGradeEN objcc_ExamGradeENS)
{
try
{
 clscc_ExamGradeENEx objcc_ExamGradeENT = new clscc_ExamGradeENEx();
clscc_ExamGradeBL.cc_ExamGradeDA.CopyTo(objcc_ExamGradeENS, objcc_ExamGradeENT);
 return objcc_ExamGradeENT;
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
public static List<clscc_ExamGradeENEx> GetObjExLst(string strCondition)
{
List <clscc_ExamGradeEN> arrObjLst = clscc_ExamGradeBL.GetObjLst(strCondition);
List <clscc_ExamGradeENEx> arrObjExLst = new List<clscc_ExamGradeENEx>();
foreach (clscc_ExamGradeEN objInFor in arrObjLst)
{
clscc_ExamGradeENEx objcc_ExamGradeENEx = new clscc_ExamGradeENEx();
clscc_ExamGradeBL.CopyTo(objInFor, objcc_ExamGradeENEx);
arrObjExLst.Add(objcc_ExamGradeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strExamGradeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_ExamGradeENEx GetObjExByExamGradeId(string strExamGradeId)
{
clscc_ExamGradeEN objcc_ExamGradeEN = clscc_ExamGradeBL.GetObjByExamGradeId(strExamGradeId);
clscc_ExamGradeENEx objcc_ExamGradeENEx = new clscc_ExamGradeENEx();
clscc_ExamGradeBL.CopyTo(objcc_ExamGradeEN, objcc_ExamGradeENEx);
return objcc_ExamGradeENEx;
}
}
}