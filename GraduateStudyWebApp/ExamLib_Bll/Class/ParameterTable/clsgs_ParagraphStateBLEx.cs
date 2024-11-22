
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ParagraphStateBLEx
 表名:gs_ParagraphState(01120745)
 生成代码版本:2020.09.09.1
 生成日期:2020/09/23 19:04:56
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
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
public static class clsgs_ParagraphStateBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_ParagraphStateENS">源对象</param>
 /// <returns>目标对象=>clsgs_ParagraphStateEN:objgs_ParagraphStateENT</returns>
 public static clsgs_ParagraphStateENEx CopyToEx(this clsgs_ParagraphStateEN objgs_ParagraphStateENS)
{
try
{
 clsgs_ParagraphStateENEx objgs_ParagraphStateENT = new clsgs_ParagraphStateENEx();
clsgs_ParagraphStateBL.gs_ParagraphStateDA.CopyTo(objgs_ParagraphStateENS, objgs_ParagraphStateENT);
 return objgs_ParagraphStateENT;
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
 /// <param name = "objgs_ParagraphStateENS">源对象</param>
 /// <returns>目标对象=>clsgs_ParagraphStateEN:objgs_ParagraphStateENT</returns>
 public static clsgs_ParagraphStateEN CopyTo(this clsgs_ParagraphStateENEx objgs_ParagraphStateENS)
{
try
{
 clsgs_ParagraphStateEN objgs_ParagraphStateENT = new clsgs_ParagraphStateEN();
clsgs_ParagraphStateBL.CopyTo(objgs_ParagraphStateENS, objgs_ParagraphStateENT);
 return objgs_ParagraphStateENT;
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
 /// 段落状态(gs_ParagraphState)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_ParagraphStateBLEx : clsgs_ParagraphStateBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_ParagraphStateDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_ParagraphStateDAEx gs_ParagraphStateDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_ParagraphStateDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_ParagraphStateENS">源对象</param>
 /// <returns>目标对象=>clsgs_ParagraphStateEN:objgs_ParagraphStateENT</returns>
 public static clsgs_ParagraphStateENEx CopyToEx(clsgs_ParagraphStateEN objgs_ParagraphStateENS)
{
try
{
 clsgs_ParagraphStateENEx objgs_ParagraphStateENT = new clsgs_ParagraphStateENEx();
clsgs_ParagraphStateBL.gs_ParagraphStateDA.CopyTo(objgs_ParagraphStateENS, objgs_ParagraphStateENT);
 return objgs_ParagraphStateENT;
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
public static List<clsgs_ParagraphStateENEx> GetObjExLst(string strCondition)
{
List <clsgs_ParagraphStateEN> arrObjLst = clsgs_ParagraphStateBL.GetObjLst(strCondition);
List <clsgs_ParagraphStateENEx> arrObjExLst = new List<clsgs_ParagraphStateENEx>();
foreach (clsgs_ParagraphStateEN objInFor in arrObjLst)
{
clsgs_ParagraphStateENEx objgs_ParagraphStateENEx = new clsgs_ParagraphStateENEx();
clsgs_ParagraphStateBL.CopyTo(objInFor, objgs_ParagraphStateENEx);
arrObjExLst.Add(objgs_ParagraphStateENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strParagraphStateId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_ParagraphStateENEx GetObjExByParagraphStateId(string strParagraphStateId)
{
clsgs_ParagraphStateEN objgs_ParagraphStateEN = clsgs_ParagraphStateBL.GetObjByParagraphStateId(strParagraphStateId);
clsgs_ParagraphStateENEx objgs_ParagraphStateENEx = new clsgs_ParagraphStateENEx();
clsgs_ParagraphStateBL.CopyTo(objgs_ParagraphStateEN, objgs_ParagraphStateENEx);
return objgs_ParagraphStateENEx;
}
}
}