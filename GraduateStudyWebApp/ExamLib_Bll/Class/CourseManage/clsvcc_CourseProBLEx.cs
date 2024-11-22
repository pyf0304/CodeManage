
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseProBLEx
 表名:vcc_CoursePro(01120213)
 * 版本:2023.01.08.1(服务器:WIN-SRV103-116)
 日期:2023/01/08 16:06:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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

using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_vcc_CourseProEx: RelatedActions_vcc_CoursePro
{
public override bool UpdRelaTabDate(string strCourseId, string strOpUser)
{
return true;
}
}
public static class clsvcc_CourseProBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_CourseProENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseProEN:objvcc_CourseProENT</returns>
 public static clsvcc_CourseProENEx CopyToEx(this clsvcc_CourseProEN objvcc_CourseProENS)
{
try
{
 clsvcc_CourseProENEx objvcc_CourseProENT = new clsvcc_CourseProENEx();
clsvcc_CourseProBL.vcc_CourseProDA.CopyTo(objvcc_CourseProENS, objvcc_CourseProENT);
 return objvcc_CourseProENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objvcc_CourseProENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseProEN:objvcc_CourseProENT</returns>
 public static clsvcc_CourseProEN CopyTo(this clsvcc_CourseProENEx objvcc_CourseProENS)
{
try
{
 clsvcc_CourseProEN objvcc_CourseProENT = new clsvcc_CourseProEN();
clsvcc_CourseProBL.CopyTo(objvcc_CourseProENS, objvcc_CourseProENT);
 return objvcc_CourseProENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// v课程Pro(vcc_CoursePro)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcc_CourseProBLEx : clsvcc_CourseProBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_CourseProDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_CourseProDAEx vcc_CourseProDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_CourseProDAEx();
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
public static List<clsvcc_CourseProENEx> GetObjExLst(string strCondition)
{
List <clsvcc_CourseProEN> arrObjLst = clsvcc_CourseProBL.GetObjLst(strCondition);
List <clsvcc_CourseProENEx> arrObjExLst = new List<clsvcc_CourseProENEx>();
foreach (clsvcc_CourseProEN objInFor in arrObjLst)
{
clsvcc_CourseProENEx objvcc_CourseProENEx = new clsvcc_CourseProENEx();
clsvcc_CourseProBL.CopyTo(objInFor, objvcc_CourseProENEx);
arrObjExLst.Add(objvcc_CourseProENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_CourseProENEx GetObjExByCourseId(string strCourseId)
{
clsvcc_CourseProEN objvcc_CourseProEN = clsvcc_CourseProBL.GetObjByCourseId(strCourseId);
clsvcc_CourseProENEx objvcc_CourseProENEx = new clsvcc_CourseProENEx();
clsvcc_CourseProBL.CopyTo(objvcc_CourseProEN, objvcc_CourseProENEx);
return objvcc_CourseProENEx;
}
}
}