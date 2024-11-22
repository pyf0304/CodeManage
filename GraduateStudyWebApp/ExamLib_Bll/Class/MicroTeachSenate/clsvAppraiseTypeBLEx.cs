
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppraiseTypeBLEx
 表名:vAppraiseType(01120308)
 生成代码版本:2020.01.15.1
 生成日期:2020/01/16 12:11:31
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
using ExamLib.Const;

namespace ExamLib.BusinessLogicEx
{
public static class clsvAppraiseTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvAppraiseTypeENS">源对象</param>
 /// <returns>目标对象=>clsvAppraiseTypeEN:objvAppraiseTypeENT</returns>
 public static clsvAppraiseTypeENEx CopyToEx(this clsvAppraiseTypeEN objvAppraiseTypeENS)
{
try
{
 clsvAppraiseTypeENEx objvAppraiseTypeENT = new clsvAppraiseTypeENEx();
clsvAppraiseTypeBL.vAppraiseTypeDA.CopyTo(objvAppraiseTypeENS, objvAppraiseTypeENT);
 return objvAppraiseTypeENT;
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
 /// <param name = "objvAppraiseTypeENS">源对象</param>
 /// <returns>目标对象=>clsvAppraiseTypeEN:objvAppraiseTypeENT</returns>
 public static clsvAppraiseTypeEN CopyTo(this clsvAppraiseTypeENEx objvAppraiseTypeENS)
{
try
{
 clsvAppraiseTypeEN objvAppraiseTypeENT = new clsvAppraiseTypeEN();
clsvAppraiseTypeBL.CopyTo(objvAppraiseTypeENS, objvAppraiseTypeENT);
 return objvAppraiseTypeENT;
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
 /// v评议类型(vAppraiseType)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvAppraiseTypeBLEx : clsvAppraiseTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvAppraiseTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvAppraiseTypeDAEx vAppraiseTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvAppraiseTypeDAEx();
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
public static List<clsvAppraiseTypeENEx> GetObjExLst(string strCondition)
{
List <clsvAppraiseTypeEN> arrObjLst = clsvAppraiseTypeBL.GetObjLst(strCondition);
List <clsvAppraiseTypeENEx> arrObjExLst = new List<clsvAppraiseTypeENEx>();
foreach (clsvAppraiseTypeEN objInFor in arrObjLst)
{
clsvAppraiseTypeENEx objvAppraiseTypeENEx = new clsvAppraiseTypeENEx();
clsvAppraiseTypeBL.CopyTo(objInFor, objvAppraiseTypeENEx);
arrObjExLst.Add(objvAppraiseTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strid_AppraiseType">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvAppraiseTypeENEx GetObjExByid_AppraiseType(string strid_AppraiseType)
{
clsvAppraiseTypeEN objvAppraiseTypeEN = clsvAppraiseTypeBL.GetObjByid_AppraiseType(strid_AppraiseType);
clsvAppraiseTypeENEx objvAppraiseTypeENEx = new clsvAppraiseTypeENEx();
clsvAppraiseTypeBL.CopyTo(objvAppraiseTypeEN, objvAppraiseTypeENEx);
return objvAppraiseTypeENEx;
}
}
}