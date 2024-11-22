
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExcellentTypeBLEx
 表名:vcc_ExcellentType(01120063)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:50:26
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
public static class clsvcc_ExcellentTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcc_ExcellentTypeENS">源对象</param>
 /// <returns>目标对象=>clsvcc_ExcellentTypeEN:objvcc_ExcellentTypeENT</returns>
 public static clsvcc_ExcellentTypeENEx CopyToEx(this clsvcc_ExcellentTypeEN objvcc_ExcellentTypeENS)
{
try
{
 clsvcc_ExcellentTypeENEx objvcc_ExcellentTypeENT = new clsvcc_ExcellentTypeENEx();
clsvcc_ExcellentTypeBL.vcc_ExcellentTypeDA.CopyTo(objvcc_ExcellentTypeENS, objvcc_ExcellentTypeENT);
 return objvcc_ExcellentTypeENT;
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
 /// <param name = "objvcc_ExcellentTypeENS">源对象</param>
 /// <returns>目标对象=>clsvcc_ExcellentTypeEN:objvcc_ExcellentTypeENT</returns>
 public static clsvcc_ExcellentTypeEN CopyTo(this clsvcc_ExcellentTypeENEx objvcc_ExcellentTypeENS)
{
try
{
 clsvcc_ExcellentTypeEN objvcc_ExcellentTypeENT = new clsvcc_ExcellentTypeEN();
clsvcc_ExcellentTypeBL.CopyTo(objvcc_ExcellentTypeENS, objvcc_ExcellentTypeENT);
 return objvcc_ExcellentTypeENT;
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
 /// v精品课程类型(vcc_ExcellentType)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcc_ExcellentTypeBLEx : clsvcc_ExcellentTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcc_ExcellentTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcc_ExcellentTypeDAEx vcc_ExcellentTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcc_ExcellentTypeDAEx();
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
public static List<clsvcc_ExcellentTypeENEx> GetObjExLst(string strCondition)
{
List <clsvcc_ExcellentTypeEN> arrObjLst = clsvcc_ExcellentTypeBL.GetObjLst(strCondition);
List <clsvcc_ExcellentTypeENEx> arrObjExLst = new List<clsvcc_ExcellentTypeENEx>();
foreach (clsvcc_ExcellentTypeEN objInFor in arrObjLst)
{
clsvcc_ExcellentTypeENEx objvcc_ExcellentTypeENEx = new clsvcc_ExcellentTypeENEx();
clsvcc_ExcellentTypeBL.CopyTo(objInFor, objvcc_ExcellentTypeENEx);
arrObjExLst.Add(objvcc_ExcellentTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strExcellentTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcc_ExcellentTypeENEx GetObjExByExcellentTypeId(string strExcellentTypeId)
{
clsvcc_ExcellentTypeEN objvcc_ExcellentTypeEN = clsvcc_ExcellentTypeBL.GetObjByExcellentTypeId(strExcellentTypeId);
clsvcc_ExcellentTypeENEx objvcc_ExcellentTypeENEx = new clsvcc_ExcellentTypeENEx();
clsvcc_ExcellentTypeBL.CopyTo(objvcc_ExcellentTypeEN, objvcc_ExcellentTypeENEx);
return objvcc_ExcellentTypeENEx;
}
}
}