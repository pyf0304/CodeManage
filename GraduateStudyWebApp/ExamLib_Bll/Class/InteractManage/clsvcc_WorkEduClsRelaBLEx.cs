
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkEduClsRelaBLEx
 表名:vcc_WorkEduClsRela(01120197)
 生成代码版本:2021.06.20.1
 生成日期:2021/06/27 00:53:54
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
public static class clsvcc_WorkEduClsRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_WorkEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkEduClsRelaEN:objvcc_WorkEduClsRelaENT</returns>
 public static clsvcc_WorkEduClsRelaENEx CopyToEx(this clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENS)
{
try
{
 clsvcc_WorkEduClsRelaENEx objvcc_WorkEduClsRelaENT = new clsvcc_WorkEduClsRelaENEx();
clsvcc_WorkEduClsRelaBL.vcc_WorkEduClsRelaDA.CopyTo(objvcc_WorkEduClsRelaENS, objvcc_WorkEduClsRelaENT);
 return objvcc_WorkEduClsRelaENT;
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
 /// <param name = "objvcc_WorkEduClsRelaENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkEduClsRelaEN:objvcc_WorkEduClsRelaENT</returns>
 public static clsvcc_WorkEduClsRelaEN CopyTo(this clsvcc_WorkEduClsRelaENEx objvcc_WorkEduClsRelaENS)
{
try
{
 clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaENT = new clsvcc_WorkEduClsRelaEN();
clsvcc_WorkEduClsRelaBL.CopyTo(objvcc_WorkEduClsRelaENS, objvcc_WorkEduClsRelaENT);
 return objvcc_WorkEduClsRelaENT;
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
 /// v作业教学班关系表(vcc_WorkEduClsRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcc_WorkEduClsRelaBLEx : clsvcc_WorkEduClsRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_WorkEduClsRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_WorkEduClsRelaDAEx vcc_WorkEduClsRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_WorkEduClsRelaDAEx();
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
public static List<clsvcc_WorkEduClsRelaENEx> GetObjExLst(string strCondition)
{
List <clsvcc_WorkEduClsRelaEN> arrObjLst = clsvcc_WorkEduClsRelaBL.GetObjLst(strCondition);
List <clsvcc_WorkEduClsRelaENEx> arrObjExLst = new List<clsvcc_WorkEduClsRelaENEx>();
foreach (clsvcc_WorkEduClsRelaEN objInFor in arrObjLst)
{
clsvcc_WorkEduClsRelaENEx objvcc_WorkEduClsRelaENEx = new clsvcc_WorkEduClsRelaENEx();
clsvcc_WorkEduClsRelaBL.CopyTo(objInFor, objvcc_WorkEduClsRelaENEx);
arrObjExLst.Add(objvcc_WorkEduClsRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngId_WorkEduClsRela">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_WorkEduClsRelaENEx GetObjExById_WorkEduClsRela(long lngId_WorkEduClsRela)
{
clsvcc_WorkEduClsRelaEN objvcc_WorkEduClsRelaEN = clsvcc_WorkEduClsRelaBL.GetObjByIdWorkEduClsRela(lngId_WorkEduClsRela);
clsvcc_WorkEduClsRelaENEx objvcc_WorkEduClsRelaENEx = new clsvcc_WorkEduClsRelaENEx();
clsvcc_WorkEduClsRelaBL.CopyTo(objvcc_WorkEduClsRelaEN, objvcc_WorkEduClsRelaENEx);
return objvcc_WorkEduClsRelaENEx;
}
}
}