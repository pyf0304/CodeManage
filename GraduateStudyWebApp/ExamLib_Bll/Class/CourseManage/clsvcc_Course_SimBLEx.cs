
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_Course_SimBLEx
 表名:vcc_Course_Sim(01120950)
 * 版本:2023.07.28.1(服务器:WIN-SRV103-116)
 日期:2023/08/13 06:25:55
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_vcc_Course_SimEx: RelatedActions_vcc_Course_Sim
{
public override bool UpdRelaTabDate(string strCourseId, string strOpUser)
{
return true;
}
}
public static class  clsvcc_Course_SimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_Course_SimENS">源对象</param>
 /// <returns>目标对象=>clsvcc_Course_SimEN:objvcc_Course_SimENT</returns>
 public static clsvcc_Course_SimENEx CopyToEx(this clsvcc_Course_SimEN objvcc_Course_SimENS)
{
try
{
 clsvcc_Course_SimENEx objvcc_Course_SimENT = new clsvcc_Course_SimENEx();
clsvcc_Course_SimBL.vcc_Course_SimDA.CopyTo(objvcc_Course_SimENS, objvcc_Course_SimENT);
 return objvcc_Course_SimENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objvcc_Course_SimENS">源对象</param>
 /// <returns>目标对象=>clsvcc_Course_SimEN:objvcc_Course_SimENT</returns>
 public static clsvcc_Course_SimEN CopyTo(this clsvcc_Course_SimENEx objvcc_Course_SimENS)
{
try
{
 clsvcc_Course_SimEN objvcc_Course_SimENT = new clsvcc_Course_SimEN();
clsvcc_Course_SimBL.CopyTo(objvcc_Course_SimENS, objvcc_Course_SimENT);
 return objvcc_Course_SimENT;
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
 /// vcc_Course_Sim(vcc_Course_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsvcc_Course_SimBLEx : clsvcc_Course_SimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_Course_SimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_Course_SimDAEx vcc_Course_SimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_Course_SimDAEx();
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
public static List<clsvcc_Course_SimENEx> GetObjExLst(string strCondition)
{
List <clsvcc_Course_SimEN> arrObjLst = clsvcc_Course_SimBL.GetObjLst(strCondition);
List <clsvcc_Course_SimENEx> arrObjExLst = new List<clsvcc_Course_SimENEx>();
foreach (clsvcc_Course_SimEN objInFor in arrObjLst)
{
clsvcc_Course_SimENEx objvcc_Course_SimENEx = new clsvcc_Course_SimENEx();
clsvcc_Course_SimBL.CopyTo(objInFor, objvcc_Course_SimENEx);
arrObjExLst.Add(objvcc_Course_SimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_Course_SimENEx GetObjExByCourseId(string strCourseId)
{
clsvcc_Course_SimEN objvcc_Course_SimEN = clsvcc_Course_SimBL.GetObjByCourseId(strCourseId);
clsvcc_Course_SimENEx objvcc_Course_SimENEx = new clsvcc_Course_SimENEx();
clsvcc_Course_SimBL.CopyTo(objvcc_Course_SimEN, objvcc_Course_SimENEx);
return objvcc_Course_SimENEx;
}
}
}