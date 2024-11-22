
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_CompositionBLEx
 表名:zx_Composition(01120761)
 生成代码版本:2020.09.24.1
 生成日期:2020/11/08 00:56:30
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文
 模块英文名:zxGroupText
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
public static class clszx_CompositionBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_CompositionENS">源对象</param>
 /// <returns>目标对象=>clszx_CompositionEN:objzx_CompositionENT</returns>
 public static clszx_CompositionENEx CopyToEx(this clszx_CompositionEN objzx_CompositionENS)
{
try
{
 clszx_CompositionENEx objzx_CompositionENT = new clszx_CompositionENEx();
clszx_CompositionBL.zx_CompositionDA.CopyTo(objzx_CompositionENS, objzx_CompositionENT);
 return objzx_CompositionENT;
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
 /// <param name = "objzx_CompositionENS">源对象</param>
 /// <returns>目标对象=>clszx_CompositionEN:objzx_CompositionENT</returns>
 public static clszx_CompositionEN CopyTo(this clszx_CompositionENEx objzx_CompositionENS)
{
try
{
 clszx_CompositionEN objzx_CompositionENT = new clszx_CompositionEN();
clszx_CompositionBL.CopyTo(objzx_CompositionENS, objzx_CompositionENT);
 return objzx_CompositionENT;
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
 /// 作文表(zx_Composition)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_CompositionBLEx : clszx_CompositionBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_CompositionDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_CompositionDAEx zx_CompositionDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_CompositionDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_CompositionENS">源对象</param>
 /// <returns>目标对象=>clszx_CompositionEN:objzx_CompositionENT</returns>
 public static clszx_CompositionENEx CopyToEx(clszx_CompositionEN objzx_CompositionENS)
{
try
{
 clszx_CompositionENEx objzx_CompositionENT = new clszx_CompositionENEx();
clszx_CompositionBL.zx_CompositionDA.CopyTo(objzx_CompositionENS, objzx_CompositionENT);
 return objzx_CompositionENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clszx_CompositionENEx> GetObjExLst(string strCondition)
{
List <clszx_CompositionEN> arrObjLst = clszx_CompositionBL.GetObjLst(strCondition);
List <clszx_CompositionENEx> arrObjExLst = new List<clszx_CompositionENEx>();
foreach (clszx_CompositionEN objInFor in arrObjLst)
{
clszx_CompositionENEx objzx_CompositionENEx = new clszx_CompositionENEx();
clszx_CompositionBL.CopyTo(objInFor, objzx_CompositionENEx);
arrObjExLst.Add(objzx_CompositionENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_CompositionENEx GetObjExByPaperId(string strPaperId)
{
clszx_CompositionEN objzx_CompositionEN = clszx_CompositionBL.GetObjByzxPaperId(strPaperId);
clszx_CompositionENEx objzx_CompositionENEx = new clszx_CompositionENEx();
clszx_CompositionBL.CopyTo(objzx_CompositionEN, objzx_CompositionENEx);
return objzx_CompositionENEx;
}
}
}