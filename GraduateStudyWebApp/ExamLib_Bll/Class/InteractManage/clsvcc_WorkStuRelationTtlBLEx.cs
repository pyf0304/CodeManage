
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelationTtlBLEx
 表名:vcc_WorkStuRelationTtl(01120356)
 生成代码版本:2021.06.20.1
 生成日期:2021/06/27 00:41:09
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsvcc_WorkStuRelationTtlBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkStuRelationTtlEN:objvcc_WorkStuRelationTtlENT</returns>
 public static clsvcc_WorkStuRelationTtlENEx CopyToEx(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlENS)
{
try
{
 clsvcc_WorkStuRelationTtlENEx objvcc_WorkStuRelationTtlENT = new clsvcc_WorkStuRelationTtlENEx();
clsvcc_WorkStuRelationTtlBL.vcc_WorkStuRelationTtlDA.CopyTo(objvcc_WorkStuRelationTtlENS, objvcc_WorkStuRelationTtlENT);
 return objvcc_WorkStuRelationTtlENT;
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
 /// <param name = "objvcc_WorkStuRelationTtlENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkStuRelationTtlEN:objvcc_WorkStuRelationTtlENT</returns>
 public static clsvcc_WorkStuRelationTtlEN CopyTo(this clsvcc_WorkStuRelationTtlENEx objvcc_WorkStuRelationTtlENS)
{
try
{
 clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlENT = new clsvcc_WorkStuRelationTtlEN();
clsvcc_WorkStuRelationTtlBL.CopyTo(objvcc_WorkStuRelationTtlENS, objvcc_WorkStuRelationTtlENT);
 return objvcc_WorkStuRelationTtlENT;
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
 /// vcc_WorkStuRelationTtl(vcc_WorkStuRelationTtl)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcc_WorkStuRelationTtlBLEx : clsvcc_WorkStuRelationTtlBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_WorkStuRelationTtlDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_WorkStuRelationTtlDAEx vcc_WorkStuRelationTtlDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_WorkStuRelationTtlDAEx();
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
public static List<clsvcc_WorkStuRelationTtlENEx> GetObjExLst(string strCondition)
{
List <clsvcc_WorkStuRelationTtlEN> arrObjLst = clsvcc_WorkStuRelationTtlBL.GetObjLst(strCondition);
List <clsvcc_WorkStuRelationTtlENEx> arrObjExLst = new List<clsvcc_WorkStuRelationTtlENEx>();
foreach (clsvcc_WorkStuRelationTtlEN objInFor in arrObjLst)
{
clsvcc_WorkStuRelationTtlENEx objvcc_WorkStuRelationTtlENEx = new clsvcc_WorkStuRelationTtlENEx();
clsvcc_WorkStuRelationTtlBL.CopyTo(objInFor, objvcc_WorkStuRelationTtlENEx);
arrObjExLst.Add(objvcc_WorkStuRelationTtlENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_StudentInfo">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_WorkStuRelationTtlENEx GetObjExByid_StudentInfo(string strid_StudentInfo)
{
clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = clsvcc_WorkStuRelationTtlBL.GetObjByIdStudentInfo(strid_StudentInfo);
clsvcc_WorkStuRelationTtlENEx objvcc_WorkStuRelationTtlENEx = new clsvcc_WorkStuRelationTtlENEx();
clsvcc_WorkStuRelationTtlBL.CopyTo(objvcc_WorkStuRelationTtlEN, objvcc_WorkStuRelationTtlENEx);
return objvcc_WorkStuRelationTtlENEx;
}
}
}