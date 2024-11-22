
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperBLEx
 表名:cc_CourseExamPaper(01120071)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:50:36
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
public static class clscc_CourseExamPaperBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseExamPaperEN:objcc_CourseExamPaperENT</returns>
 public static clscc_CourseExamPaperENEx CopyToEx(this clscc_CourseExamPaperEN objcc_CourseExamPaperENS)
{
try
{
 clscc_CourseExamPaperENEx objcc_CourseExamPaperENT = new clscc_CourseExamPaperENEx();
clscc_CourseExamPaperBL.cc_CourseExamPaperDA.CopyTo(objcc_CourseExamPaperENS, objcc_CourseExamPaperENT);
 return objcc_CourseExamPaperENT;
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
 /// <param name = "objcc_CourseExamPaperENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseExamPaperEN:objcc_CourseExamPaperENT</returns>
 public static clscc_CourseExamPaperEN CopyTo(this clscc_CourseExamPaperENEx objcc_CourseExamPaperENS)
{
try
{
 clscc_CourseExamPaperEN objcc_CourseExamPaperENT = new clscc_CourseExamPaperEN();
clscc_CourseExamPaperBL.CopyTo(objcc_CourseExamPaperENS, objcc_CourseExamPaperENT);
 return objcc_CourseExamPaperENT;
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
 /// 考卷(cc_CourseExamPaper)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_CourseExamPaperBLEx : clscc_CourseExamPaperBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_CourseExamPaperDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_CourseExamPaperDAEx cc_CourseExamPaperDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_CourseExamPaperDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseExamPaperEN:objcc_CourseExamPaperENT</returns>
 public static clscc_CourseExamPaperENEx CopyToEx(clscc_CourseExamPaperEN objcc_CourseExamPaperENS)
{
try
{
 clscc_CourseExamPaperENEx objcc_CourseExamPaperENT = new clscc_CourseExamPaperENEx();
clscc_CourseExamPaperBL.cc_CourseExamPaperDA.CopyTo(objcc_CourseExamPaperENS, objcc_CourseExamPaperENT);
 return objcc_CourseExamPaperENT;
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
public static List<clscc_CourseExamPaperENEx> GetObjExLst(string strCondition)
{
List <clscc_CourseExamPaperEN> arrObjLst = clscc_CourseExamPaperBL.GetObjLst(strCondition);
List <clscc_CourseExamPaperENEx> arrObjExLst = new List<clscc_CourseExamPaperENEx>();
foreach (clscc_CourseExamPaperEN objInFor in arrObjLst)
{
clscc_CourseExamPaperENEx objcc_CourseExamPaperENEx = new clscc_CourseExamPaperENEx();
clscc_CourseExamPaperBL.CopyTo(objInFor, objcc_CourseExamPaperENEx);
arrObjExLst.Add(objcc_CourseExamPaperENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCourseExamPaperId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_CourseExamPaperENEx GetObjExByCourseExamPaperId(string strCourseExamPaperId)
{
clscc_CourseExamPaperEN objcc_CourseExamPaperEN = clscc_CourseExamPaperBL.GetObjByCourseExamPaperId(strCourseExamPaperId);
clscc_CourseExamPaperENEx objcc_CourseExamPaperENEx = new clscc_CourseExamPaperENEx();
clscc_CourseExamPaperBL.CopyTo(objcc_CourseExamPaperEN, objcc_CourseExamPaperENEx);
return objcc_CourseExamPaperENEx;
}
}
}