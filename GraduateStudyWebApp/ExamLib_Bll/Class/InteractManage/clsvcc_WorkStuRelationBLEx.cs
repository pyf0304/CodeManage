
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelationBLEx
 表名:vcc_WorkStuRelation(01120198)
 生成代码版本:2021.06.20.1
 生成日期:2021/06/27 00:36:23
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
public static class clsvcc_WorkStuRelationBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkStuRelationEN:objvcc_WorkStuRelationENT</returns>
 public static clsvcc_WorkStuRelationENEx CopyToEx(this clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENS)
{
try
{
 clsvcc_WorkStuRelationENEx objvcc_WorkStuRelationENT = new clsvcc_WorkStuRelationENEx();
clsvcc_WorkStuRelationBL.vcc_WorkStuRelationDA.CopyTo(objvcc_WorkStuRelationENS, objvcc_WorkStuRelationENT);
 return objvcc_WorkStuRelationENT;
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
 /// <param name = "objvcc_WorkStuRelationENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkStuRelationEN:objvcc_WorkStuRelationENT</returns>
 public static clsvcc_WorkStuRelationEN CopyTo(this clsvcc_WorkStuRelationENEx objvcc_WorkStuRelationENS)
{
try
{
 clsvcc_WorkStuRelationEN objvcc_WorkStuRelationENT = new clsvcc_WorkStuRelationEN();
clsvcc_WorkStuRelationBL.CopyTo(objvcc_WorkStuRelationENS, objvcc_WorkStuRelationENT);
 return objvcc_WorkStuRelationENT;
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
 /// v作业与学生关系表(vcc_WorkStuRelation)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcc_WorkStuRelationBLEx : clsvcc_WorkStuRelationBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_WorkStuRelationDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_WorkStuRelationDAEx vcc_WorkStuRelationDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_WorkStuRelationDAEx();
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
public static List<clsvcc_WorkStuRelationENEx> GetObjExLst(string strCondition)
{
List <clsvcc_WorkStuRelationEN> arrObjLst = clsvcc_WorkStuRelationBL.GetObjLst(strCondition);
List <clsvcc_WorkStuRelationENEx> arrObjExLst = new List<clsvcc_WorkStuRelationENEx>();
foreach (clsvcc_WorkStuRelationEN objInFor in arrObjLst)
{
clsvcc_WorkStuRelationENEx objvcc_WorkStuRelationENEx = new clsvcc_WorkStuRelationENEx();
clsvcc_WorkStuRelationBL.CopyTo(objInFor, objvcc_WorkStuRelationENEx);
arrObjExLst.Add(objvcc_WorkStuRelationENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngId_WorkStuRelation">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_WorkStuRelationENEx GetObjExById_WorkStuRelation(long lngId_WorkStuRelation)
{
clsvcc_WorkStuRelationEN objvcc_WorkStuRelationEN = clsvcc_WorkStuRelationBL.GetObjByIdWorkStuRelation(lngId_WorkStuRelation);
clsvcc_WorkStuRelationENEx objvcc_WorkStuRelationENEx = new clsvcc_WorkStuRelationENEx();
clsvcc_WorkStuRelationBL.CopyTo(objvcc_WorkStuRelationEN, objvcc_WorkStuRelationENEx);
return objvcc_WorkStuRelationENEx;
}
}
}