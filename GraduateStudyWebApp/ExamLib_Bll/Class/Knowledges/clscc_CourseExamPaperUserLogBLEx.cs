
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperUserLogBLEx
 表名:cc_CourseExamPaperUserLog(01120090)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 17:24:43
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
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
public static class clscc_CourseExamPaperUserLogBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseExamPaperUserLogEN:objcc_CourseExamPaperUserLogENT</returns>
 public static clscc_CourseExamPaperUserLogENEx CopyToEx(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENS)
{
try
{
 clscc_CourseExamPaperUserLogENEx objcc_CourseExamPaperUserLogENT = new clscc_CourseExamPaperUserLogENEx();
clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.CopyTo(objcc_CourseExamPaperUserLogENS, objcc_CourseExamPaperUserLogENT);
 return objcc_CourseExamPaperUserLogENT;
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
 /// <param name = "objcc_CourseExamPaperUserLogENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseExamPaperUserLogEN:objcc_CourseExamPaperUserLogENT</returns>
 public static clscc_CourseExamPaperUserLogEN CopyTo(this clscc_CourseExamPaperUserLogENEx objcc_CourseExamPaperUserLogENS)
{
try
{
 clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENT = new clscc_CourseExamPaperUserLogEN();
clscc_CourseExamPaperUserLogBL.CopyTo(objcc_CourseExamPaperUserLogENS, objcc_CourseExamPaperUserLogENT);
 return objcc_CourseExamPaperUserLogENT;
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
 /// 学生答试卷日志(cc_CourseExamPaperUserLog)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_CourseExamPaperUserLogBLEx : clscc_CourseExamPaperUserLogBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_CourseExamPaperUserLogDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_CourseExamPaperUserLogDAEx cc_CourseExamPaperUserLogDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_CourseExamPaperUserLogDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseExamPaperUserLogEN:objcc_CourseExamPaperUserLogENT</returns>
 public static clscc_CourseExamPaperUserLogENEx CopyToEx(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENS)
{
try
{
 clscc_CourseExamPaperUserLogENEx objcc_CourseExamPaperUserLogENT = new clscc_CourseExamPaperUserLogENEx();
clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.CopyTo(objcc_CourseExamPaperUserLogENS, objcc_CourseExamPaperUserLogENT);
 return objcc_CourseExamPaperUserLogENT;
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
public static List<clscc_CourseExamPaperUserLogENEx> GetObjExLst(string strCondition)
{
List <clscc_CourseExamPaperUserLogEN> arrObjLst = clscc_CourseExamPaperUserLogBL.GetObjLst(strCondition);
List <clscc_CourseExamPaperUserLogENEx> arrObjExLst = new List<clscc_CourseExamPaperUserLogENEx>();
foreach (clscc_CourseExamPaperUserLogEN objInFor in arrObjLst)
{
clscc_CourseExamPaperUserLogENEx objcc_CourseExamPaperUserLogENEx = new clscc_CourseExamPaperUserLogENEx();
clscc_CourseExamPaperUserLogBL.CopyTo(objInFor, objcc_CourseExamPaperUserLogENEx);
arrObjExLst.Add(objcc_CourseExamPaperUserLogENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_CourseExamPaperUserLogENEx GetObjExBymId(long lngmId)
{
clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = clscc_CourseExamPaperUserLogBL.GetObjBymId(lngmId);
clscc_CourseExamPaperUserLogENEx objcc_CourseExamPaperUserLogENEx = new clscc_CourseExamPaperUserLogENEx();
clscc_CourseExamPaperUserLogBL.CopyTo(objcc_CourseExamPaperUserLogEN, objcc_CourseExamPaperUserLogENEx);
return objcc_CourseExamPaperUserLogENEx;
}
}
}