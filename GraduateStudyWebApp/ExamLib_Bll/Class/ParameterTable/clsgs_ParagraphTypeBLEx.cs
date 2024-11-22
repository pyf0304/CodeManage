
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ParagraphTypeBLEx
 表名:gs_ParagraphType(01120746)
 生成代码版本:2020.09.09.1
 生成日期:2020/09/23 19:05:00
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
public static class clsgs_ParagraphTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_ParagraphTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_ParagraphTypeEN:objgs_ParagraphTypeENT</returns>
 public static clsgs_ParagraphTypeENEx CopyToEx(this clsgs_ParagraphTypeEN objgs_ParagraphTypeENS)
{
try
{
 clsgs_ParagraphTypeENEx objgs_ParagraphTypeENT = new clsgs_ParagraphTypeENEx();
clsgs_ParagraphTypeBL.gs_ParagraphTypeDA.CopyTo(objgs_ParagraphTypeENS, objgs_ParagraphTypeENT);
 return objgs_ParagraphTypeENT;
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
 /// <param name = "objgs_ParagraphTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_ParagraphTypeEN:objgs_ParagraphTypeENT</returns>
 public static clsgs_ParagraphTypeEN CopyTo(this clsgs_ParagraphTypeENEx objgs_ParagraphTypeENS)
{
try
{
 clsgs_ParagraphTypeEN objgs_ParagraphTypeENT = new clsgs_ParagraphTypeEN();
clsgs_ParagraphTypeBL.CopyTo(objgs_ParagraphTypeENS, objgs_ParagraphTypeENT);
 return objgs_ParagraphTypeENT;
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
 /// 段落类型(gs_ParagraphType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_ParagraphTypeBLEx : clsgs_ParagraphTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_ParagraphTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_ParagraphTypeDAEx gs_ParagraphTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_ParagraphTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_ParagraphTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_ParagraphTypeEN:objgs_ParagraphTypeENT</returns>
 public static clsgs_ParagraphTypeENEx CopyToEx(clsgs_ParagraphTypeEN objgs_ParagraphTypeENS)
{
try
{
 clsgs_ParagraphTypeENEx objgs_ParagraphTypeENT = new clsgs_ParagraphTypeENEx();
clsgs_ParagraphTypeBL.gs_ParagraphTypeDA.CopyTo(objgs_ParagraphTypeENS, objgs_ParagraphTypeENT);
 return objgs_ParagraphTypeENT;
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
public static List<clsgs_ParagraphTypeENEx> GetObjExLst(string strCondition)
{
List <clsgs_ParagraphTypeEN> arrObjLst = clsgs_ParagraphTypeBL.GetObjLst(strCondition);
List <clsgs_ParagraphTypeENEx> arrObjExLst = new List<clsgs_ParagraphTypeENEx>();
foreach (clsgs_ParagraphTypeEN objInFor in arrObjLst)
{
clsgs_ParagraphTypeENEx objgs_ParagraphTypeENEx = new clsgs_ParagraphTypeENEx();
clsgs_ParagraphTypeBL.CopyTo(objInFor, objgs_ParagraphTypeENEx);
arrObjExLst.Add(objgs_ParagraphTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strParagraphTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_ParagraphTypeENEx GetObjExByParagraphTypeId(string strParagraphTypeId)
{
clsgs_ParagraphTypeEN objgs_ParagraphTypeEN = clsgs_ParagraphTypeBL.GetObjByParagraphTypeId(strParagraphTypeId);
clsgs_ParagraphTypeENEx objgs_ParagraphTypeENEx = new clsgs_ParagraphTypeENEx();
clsgs_ParagraphTypeBL.CopyTo(objgs_ParagraphTypeEN, objgs_ParagraphTypeENEx);
return objgs_ParagraphTypeENEx;
}
}
}