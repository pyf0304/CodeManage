
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseKnowledgesBLEx
 表名:vcc_CourseKnowledges(01120141)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:50:48
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
public static class clsvcc_CourseKnowledgesBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseKnowledgesEN:objvcc_CourseKnowledgesENT</returns>
 public static clsvcc_CourseKnowledgesENEx CopyToEx(this clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesENS)
{
try
{
 clsvcc_CourseKnowledgesENEx objvcc_CourseKnowledgesENT = new clsvcc_CourseKnowledgesENEx();
clsvcc_CourseKnowledgesBL.vcc_CourseKnowledgesDA.CopyTo(objvcc_CourseKnowledgesENS, objvcc_CourseKnowledgesENT);
 return objvcc_CourseKnowledgesENT;
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
 /// <param name = "objvcc_CourseKnowledgesENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseKnowledgesEN:objvcc_CourseKnowledgesENT</returns>
 public static clsvcc_CourseKnowledgesEN CopyTo(this clsvcc_CourseKnowledgesENEx objvcc_CourseKnowledgesENS)
{
try
{
 clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesENT = new clsvcc_CourseKnowledgesEN();
clsvcc_CourseKnowledgesBL.CopyTo(objvcc_CourseKnowledgesENS, objvcc_CourseKnowledgesENT);
 return objvcc_CourseKnowledgesENT;
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
 /// v课程知识点(vcc_CourseKnowledges)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcc_CourseKnowledgesBLEx : clsvcc_CourseKnowledgesBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_CourseKnowledgesDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_CourseKnowledgesDAEx vcc_CourseKnowledgesDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_CourseKnowledgesDAEx();
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
public static List<clsvcc_CourseKnowledgesENEx> GetObjExLst(string strCondition)
{
List <clsvcc_CourseKnowledgesEN> arrObjLst = clsvcc_CourseKnowledgesBL.GetObjLst(strCondition);
List <clsvcc_CourseKnowledgesENEx> arrObjExLst = new List<clsvcc_CourseKnowledgesENEx>();
foreach (clsvcc_CourseKnowledgesEN objInFor in arrObjLst)
{
clsvcc_CourseKnowledgesENEx objvcc_CourseKnowledgesENEx = new clsvcc_CourseKnowledgesENEx();
clsvcc_CourseKnowledgesBL.CopyTo(objInFor, objvcc_CourseKnowledgesENEx);
arrObjExLst.Add(objvcc_CourseKnowledgesENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_CourseKnowledgesENEx GetObjExByCourseKnowledgeId(string strCourseKnowledgeId)
{
clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = clsvcc_CourseKnowledgesBL.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
clsvcc_CourseKnowledgesENEx objvcc_CourseKnowledgesENEx = new clsvcc_CourseKnowledgesENEx();
clsvcc_CourseKnowledgesBL.CopyTo(objvcc_CourseKnowledgesEN, objvcc_CourseKnowledgesENEx);
return objvcc_CourseKnowledgesENEx;
}
}
}