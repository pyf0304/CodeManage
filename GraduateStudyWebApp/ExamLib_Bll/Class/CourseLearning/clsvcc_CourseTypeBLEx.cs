
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTypeBLEx
 表名:vcc_CourseType(01120059)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:50:17
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
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
public static class clsvcc_CourseTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_CourseTypeENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseTypeEN:objvcc_CourseTypeENT</returns>
 public static clsvcc_CourseTypeENEx CopyToEx(this clsvcc_CourseTypeEN objvcc_CourseTypeENS)
{
try
{
 clsvcc_CourseTypeENEx objvcc_CourseTypeENT = new clsvcc_CourseTypeENEx();
clsvcc_CourseTypeBL.vcc_CourseTypeDA.CopyTo(objvcc_CourseTypeENS, objvcc_CourseTypeENT);
 return objvcc_CourseTypeENT;
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
 /// <param name = "objvcc_CourseTypeENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseTypeEN:objvcc_CourseTypeENT</returns>
 public static clsvcc_CourseTypeEN CopyTo(this clsvcc_CourseTypeENEx objvcc_CourseTypeENS)
{
try
{
 clsvcc_CourseTypeEN objvcc_CourseTypeENT = new clsvcc_CourseTypeEN();
clsvcc_CourseTypeBL.CopyTo(objvcc_CourseTypeENS, objvcc_CourseTypeENT);
 return objvcc_CourseTypeENT;
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
 /// v课程类型(vcc_CourseType)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcc_CourseTypeBLEx : clsvcc_CourseTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_CourseTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_CourseTypeDAEx vcc_CourseTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_CourseTypeDAEx();
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
public static List<clsvcc_CourseTypeENEx> GetObjExLst(string strCondition)
{
List <clsvcc_CourseTypeEN> arrObjLst = clsvcc_CourseTypeBL.GetObjLst(strCondition);
List <clsvcc_CourseTypeENEx> arrObjExLst = new List<clsvcc_CourseTypeENEx>();
foreach (clsvcc_CourseTypeEN objInFor in arrObjLst)
{
clsvcc_CourseTypeENEx objvcc_CourseTypeENEx = new clsvcc_CourseTypeENEx();
clsvcc_CourseTypeBL.CopyTo(objInFor, objvcc_CourseTypeENEx);
arrObjExLst.Add(objvcc_CourseTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCourseTypeID">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_CourseTypeENEx GetObjExByCourseTypeID(string strCourseTypeID)
{
clsvcc_CourseTypeEN objvcc_CourseTypeEN = clsvcc_CourseTypeBL.GetObjByCourseTypeId(strCourseTypeID);
clsvcc_CourseTypeENEx objvcc_CourseTypeENEx = new clsvcc_CourseTypeENEx();
clsvcc_CourseTypeBL.CopyTo(objvcc_CourseTypeEN, objvcc_CourseTypeENEx);
return objvcc_CourseTypeENEx;
}
}
}