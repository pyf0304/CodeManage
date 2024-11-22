
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ParagraphStateBLEx
 表名:zx_ParagraphState(01120820)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:59:45
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数
 模块英文名:ParameterTable
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
public static class clszx_ParagraphStateBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ParagraphStateENS">源对象</param>
 /// <returns>目标对象=>clszx_ParagraphStateEN:objzx_ParagraphStateENT</returns>
 public static clszx_ParagraphStateENEx CopyToEx(this clszx_ParagraphStateEN objzx_ParagraphStateENS)
{
try
{
 clszx_ParagraphStateENEx objzx_ParagraphStateENT = new clszx_ParagraphStateENEx();
clszx_ParagraphStateBL.zx_ParagraphStateDA.CopyTo(objzx_ParagraphStateENS, objzx_ParagraphStateENT);
 return objzx_ParagraphStateENT;
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
 /// <param name = "objzx_ParagraphStateENS">源对象</param>
 /// <returns>目标对象=>clszx_ParagraphStateEN:objzx_ParagraphStateENT</returns>
 public static clszx_ParagraphStateEN CopyTo(this clszx_ParagraphStateENEx objzx_ParagraphStateENS)
{
try
{
 clszx_ParagraphStateEN objzx_ParagraphStateENT = new clszx_ParagraphStateEN();
clszx_ParagraphStateBL.CopyTo(objzx_ParagraphStateENS, objzx_ParagraphStateENT);
 return objzx_ParagraphStateENT;
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
 /// 中学段落状态(zx_ParagraphState)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_ParagraphStateBLEx : clszx_ParagraphStateBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_ParagraphStateDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_ParagraphStateDAEx zx_ParagraphStateDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_ParagraphStateDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ParagraphStateENS">源对象</param>
 /// <returns>目标对象=>clszx_ParagraphStateEN:objzx_ParagraphStateENT</returns>
 public static clszx_ParagraphStateENEx CopyToEx(clszx_ParagraphStateEN objzx_ParagraphStateENS)
{
try
{
 clszx_ParagraphStateENEx objzx_ParagraphStateENT = new clszx_ParagraphStateENEx();
clszx_ParagraphStateBL.zx_ParagraphStateDA.CopyTo(objzx_ParagraphStateENS, objzx_ParagraphStateENT);
 return objzx_ParagraphStateENT;
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
public static List<clszx_ParagraphStateENEx> GetObjExLst(string strCondition)
{
List <clszx_ParagraphStateEN> arrObjLst = clszx_ParagraphStateBL.GetObjLst(strCondition);
List <clszx_ParagraphStateENEx> arrObjExLst = new List<clszx_ParagraphStateENEx>();
foreach (clszx_ParagraphStateEN objInFor in arrObjLst)
{
clszx_ParagraphStateENEx objzx_ParagraphStateENEx = new clszx_ParagraphStateENEx();
clszx_ParagraphStateBL.CopyTo(objInFor, objzx_ParagraphStateENEx);
arrObjExLst.Add(objzx_ParagraphStateENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxParagraphStateId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_ParagraphStateENEx GetObjExByzxParagraphStateId(string strzxParagraphStateId)
{
clszx_ParagraphStateEN objzx_ParagraphStateEN = clszx_ParagraphStateBL.GetObjByzxParagraphStateId(strzxParagraphStateId);
clszx_ParagraphStateENEx objzx_ParagraphStateENEx = new clszx_ParagraphStateENEx();
clszx_ParagraphStateBL.CopyTo(objzx_ParagraphStateEN, objzx_ParagraphStateENEx);
return objzx_ParagraphStateENEx;
}
}
}