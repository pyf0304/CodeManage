
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapterBLEx
 表名:vcc_CourseChapter(01120061)
 生成代码版本:2021.02.03.1
 生成日期:2021/02/08 18:53:08
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
public static class clsvcc_CourseChapterBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_CourseChapterENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseChapterEN:objvcc_CourseChapterENT</returns>
 public static clsvcc_CourseChapterENEx CopyToEx(this clsvcc_CourseChapterEN objvcc_CourseChapterENS)
{
try
{
 clsvcc_CourseChapterENEx objvcc_CourseChapterENT = new clsvcc_CourseChapterENEx();
clsvcc_CourseChapterBL.vcc_CourseChapterDA.CopyTo(objvcc_CourseChapterENS, objvcc_CourseChapterENT);
 return objvcc_CourseChapterENT;
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
 /// <param name = "objvcc_CourseChapterENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseChapterEN:objvcc_CourseChapterENT</returns>
 public static clsvcc_CourseChapterEN CopyTo(this clsvcc_CourseChapterENEx objvcc_CourseChapterENS)
{
try
{
 clsvcc_CourseChapterEN objvcc_CourseChapterENT = new clsvcc_CourseChapterEN();
clsvcc_CourseChapterBL.CopyTo(objvcc_CourseChapterENS, objvcc_CourseChapterENT);
 return objvcc_CourseChapterENT;
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
 /// v课程章节(vcc_CourseChapter)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcc_CourseChapterBLEx : clsvcc_CourseChapterBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_CourseChapterDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_CourseChapterDAEx vcc_CourseChapterDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_CourseChapterDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvcc_CourseChapterENEx> GetObjExLst(string strCondition)
{
List <clsvcc_CourseChapterEN> arrObjLst = clsvcc_CourseChapterBL.GetObjLst(strCondition);
List <clsvcc_CourseChapterENEx> arrObjExLst = new List<clsvcc_CourseChapterENEx>();
foreach (clsvcc_CourseChapterEN objInFor in arrObjLst)
{
clsvcc_CourseChapterENEx objvcc_CourseChapterENEx = new clsvcc_CourseChapterENEx();
clsvcc_CourseChapterBL.CopyTo(objInFor, objvcc_CourseChapterENEx);
arrObjExLst.Add(objvcc_CourseChapterENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_CourseChapterENEx GetObjExByCourseChapterId(string strCourseChapterId)
{
clsvcc_CourseChapterEN objvcc_CourseChapterEN = clsvcc_CourseChapterBL.GetObjByCourseChapterId(strCourseChapterId);
clsvcc_CourseChapterENEx objvcc_CourseChapterENEx = new clsvcc_CourseChapterENEx();
clsvcc_CourseChapterBL.CopyTo(objvcc_CourseChapterEN, objvcc_CourseChapterENEx);
return objvcc_CourseChapterENEx;
}
}
}