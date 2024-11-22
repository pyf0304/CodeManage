
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseTeacherRelationBLEx
 表名:cc_CourseTeacherRelation(01120097)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 17:25:14
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理
 模块英文名:CourseManage
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
public static class clscc_CourseTeacherRelationBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_CourseTeacherRelationENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseTeacherRelationEN:objcc_CourseTeacherRelationENT</returns>
 public static clscc_CourseTeacherRelationENEx CopyToEx(this clscc_CourseTeacherRelationEN objcc_CourseTeacherRelationENS)
{
try
{
 clscc_CourseTeacherRelationENEx objcc_CourseTeacherRelationENT = new clscc_CourseTeacherRelationENEx();
clscc_CourseTeacherRelationBL.cc_CourseTeacherRelationDA.CopyTo(objcc_CourseTeacherRelationENS, objcc_CourseTeacherRelationENT);
 return objcc_CourseTeacherRelationENT;
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
 /// <param name = "objcc_CourseTeacherRelationENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseTeacherRelationEN:objcc_CourseTeacherRelationENT</returns>
 public static clscc_CourseTeacherRelationEN CopyTo(this clscc_CourseTeacherRelationENEx objcc_CourseTeacherRelationENS)
{
try
{
 clscc_CourseTeacherRelationEN objcc_CourseTeacherRelationENT = new clscc_CourseTeacherRelationEN();
clscc_CourseTeacherRelationBL.CopyTo(objcc_CourseTeacherRelationENS, objcc_CourseTeacherRelationENT);
 return objcc_CourseTeacherRelationENT;
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
 /// 课程教师关系(cc_CourseTeacherRelation)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_CourseTeacherRelationBLEx : clscc_CourseTeacherRelationBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_CourseTeacherRelationDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_CourseTeacherRelationDAEx cc_CourseTeacherRelationDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_CourseTeacherRelationDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_CourseTeacherRelationENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseTeacherRelationEN:objcc_CourseTeacherRelationENT</returns>
 public static clscc_CourseTeacherRelationENEx CopyToEx(clscc_CourseTeacherRelationEN objcc_CourseTeacherRelationENS)
{
try
{
 clscc_CourseTeacherRelationENEx objcc_CourseTeacherRelationENT = new clscc_CourseTeacherRelationENEx();
clscc_CourseTeacherRelationBL.cc_CourseTeacherRelationDA.CopyTo(objcc_CourseTeacherRelationENS, objcc_CourseTeacherRelationENT);
 return objcc_CourseTeacherRelationENT;
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
public static List<clscc_CourseTeacherRelationENEx> GetObjExLst(string strCondition)
{
List <clscc_CourseTeacherRelationEN> arrObjLst = clscc_CourseTeacherRelationBL.GetObjLst(strCondition);
List <clscc_CourseTeacherRelationENEx> arrObjExLst = new List<clscc_CourseTeacherRelationENEx>();
foreach (clscc_CourseTeacherRelationEN objInFor in arrObjLst)
{
clscc_CourseTeacherRelationENEx objcc_CourseTeacherRelationENEx = new clscc_CourseTeacherRelationENEx();
clscc_CourseTeacherRelationBL.CopyTo(objInFor, objcc_CourseTeacherRelationENEx);
arrObjExLst.Add(objcc_CourseTeacherRelationENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_CourseTeacherRelationENEx GetObjExByCourseTeacherRelationId(long lngCourseTeacherRelationId)
{
clscc_CourseTeacherRelationEN objcc_CourseTeacherRelationEN = clscc_CourseTeacherRelationBL.GetObjByCourseTeacherRelationId(lngCourseTeacherRelationId);
clscc_CourseTeacherRelationENEx objcc_CourseTeacherRelationENEx = new clscc_CourseTeacherRelationENEx();
clscc_CourseTeacherRelationBL.CopyTo(objcc_CourseTeacherRelationEN, objcc_CourseTeacherRelationENEx);
return objcc_CourseTeacherRelationENEx;
}
}
}