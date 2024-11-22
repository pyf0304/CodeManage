
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapter4KnowledgeBLEx
 表名:vcc_CourseChapter4Knowledge(01120158)
 生成代码版本:2021.06.19.1
 生成日期:2021/06/19 17:30:53
 生成者:pyf
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
public static class clsvcc_CourseChapter4KnowledgeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_CourseChapter4KnowledgeENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseChapter4KnowledgeEN:objvcc_CourseChapter4KnowledgeENT</returns>
 public static clsvcc_CourseChapter4KnowledgeENEx CopyToEx(this clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeENS)
{
try
{
 clsvcc_CourseChapter4KnowledgeENEx objvcc_CourseChapter4KnowledgeENT = new clsvcc_CourseChapter4KnowledgeENEx();
clsvcc_CourseChapter4KnowledgeBL.vcc_CourseChapter4KnowledgeDA.CopyTo(objvcc_CourseChapter4KnowledgeENS, objvcc_CourseChapter4KnowledgeENT);
 return objvcc_CourseChapter4KnowledgeENT;
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
 /// <param name = "objvcc_CourseChapter4KnowledgeENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseChapter4KnowledgeEN:objvcc_CourseChapter4KnowledgeENT</returns>
 public static clsvcc_CourseChapter4KnowledgeEN CopyTo(this clsvcc_CourseChapter4KnowledgeENEx objvcc_CourseChapter4KnowledgeENS)
{
try
{
 clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeENT = new clsvcc_CourseChapter4KnowledgeEN();
clsvcc_CourseChapter4KnowledgeBL.CopyTo(objvcc_CourseChapter4KnowledgeENS, objvcc_CourseChapter4KnowledgeENT);
 return objvcc_CourseChapter4KnowledgeENT;
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
 /// v课程章节表4知识点(vcc_CourseChapter4Knowledge)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcc_CourseChapter4KnowledgeBLEx : clsvcc_CourseChapter4KnowledgeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_CourseChapter4KnowledgeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_CourseChapter4KnowledgeDAEx vcc_CourseChapter4KnowledgeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_CourseChapter4KnowledgeDAEx();
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
public static List<clsvcc_CourseChapter4KnowledgeENEx> GetObjExLst(string strCondition)
{
List <clsvcc_CourseChapter4KnowledgeEN> arrObjLst = clsvcc_CourseChapter4KnowledgeBL.GetObjLst(strCondition);
List <clsvcc_CourseChapter4KnowledgeENEx> arrObjExLst = new List<clsvcc_CourseChapter4KnowledgeENEx>();
foreach (clsvcc_CourseChapter4KnowledgeEN objInFor in arrObjLst)
{
clsvcc_CourseChapter4KnowledgeENEx objvcc_CourseChapter4KnowledgeENEx = new clsvcc_CourseChapter4KnowledgeENEx();
clsvcc_CourseChapter4KnowledgeBL.CopyTo(objInFor, objvcc_CourseChapter4KnowledgeENEx);
arrObjExLst.Add(objvcc_CourseChapter4KnowledgeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_CourseChapter4KnowledgeENEx GetObjExByCourseChapterId(string strCourseChapterId)
{
clsvcc_CourseChapter4KnowledgeEN objvcc_CourseChapter4KnowledgeEN = clsvcc_CourseChapter4KnowledgeBL.GetObjByCourseChapterId(strCourseChapterId);
clsvcc_CourseChapter4KnowledgeENEx objvcc_CourseChapter4KnowledgeENEx = new clsvcc_CourseChapter4KnowledgeENEx();
clsvcc_CourseChapter4KnowledgeBL.CopyTo(objvcc_CourseChapter4KnowledgeEN, objvcc_CourseChapter4KnowledgeENEx);
return objvcc_CourseChapter4KnowledgeENEx;
}
}
}