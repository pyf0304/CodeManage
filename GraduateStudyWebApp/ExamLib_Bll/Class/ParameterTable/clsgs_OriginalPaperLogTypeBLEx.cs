
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_OriginalPaperLogTypeBLEx
 表名:gs_OriginalPaperLogType(01120679)
 生成代码版本:2020.06.13.1
 生成日期:2020/06/16 17:10:14
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
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
public static class clsgs_OriginalPaperLogTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_OriginalPaperLogTypeEN:objgs_OriginalPaperLogTypeENT</returns>
 public static clsgs_OriginalPaperLogTypeENEx CopyToEx(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeENS)
{
try
{
 clsgs_OriginalPaperLogTypeENEx objgs_OriginalPaperLogTypeENT = new clsgs_OriginalPaperLogTypeENEx();
clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.CopyTo(objgs_OriginalPaperLogTypeENS, objgs_OriginalPaperLogTypeENT);
 return objgs_OriginalPaperLogTypeENT;
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
 /// <param name = "objgs_OriginalPaperLogTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_OriginalPaperLogTypeEN:objgs_OriginalPaperLogTypeENT</returns>
 public static clsgs_OriginalPaperLogTypeEN CopyTo(this clsgs_OriginalPaperLogTypeENEx objgs_OriginalPaperLogTypeENS)
{
try
{
 clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeENT = new clsgs_OriginalPaperLogTypeEN();
clsgs_OriginalPaperLogTypeBL.CopyTo(objgs_OriginalPaperLogTypeENS, objgs_OriginalPaperLogTypeENT);
 return objgs_OriginalPaperLogTypeENT;
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
 /// 论文日志类型(gs_OriginalPaperLogType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_OriginalPaperLogTypeBLEx : clsgs_OriginalPaperLogTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_OriginalPaperLogTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_OriginalPaperLogTypeDAEx gs_OriginalPaperLogTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_OriginalPaperLogTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_OriginalPaperLogTypeEN:objgs_OriginalPaperLogTypeENT</returns>
 public static clsgs_OriginalPaperLogTypeENEx CopyToEx(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeENS)
{
try
{
 clsgs_OriginalPaperLogTypeENEx objgs_OriginalPaperLogTypeENT = new clsgs_OriginalPaperLogTypeENEx();
clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.CopyTo(objgs_OriginalPaperLogTypeENS, objgs_OriginalPaperLogTypeENT);
 return objgs_OriginalPaperLogTypeENT;
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
public static List<clsgs_OriginalPaperLogTypeENEx> GetObjExLst(string strCondition)
{
List <clsgs_OriginalPaperLogTypeEN> arrObjLst = clsgs_OriginalPaperLogTypeBL.GetObjLst(strCondition);
List <clsgs_OriginalPaperLogTypeENEx> arrObjExLst = new List<clsgs_OriginalPaperLogTypeENEx>();
foreach (clsgs_OriginalPaperLogTypeEN objInFor in arrObjLst)
{
clsgs_OriginalPaperLogTypeENEx objgs_OriginalPaperLogTypeENEx = new clsgs_OriginalPaperLogTypeENEx();
clsgs_OriginalPaperLogTypeBL.CopyTo(objInFor, objgs_OriginalPaperLogTypeENEx);
arrObjExLst.Add(objgs_OriginalPaperLogTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strLogTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_OriginalPaperLogTypeENEx GetObjExByLogTypeId(string strLogTypeId)
{
clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = clsgs_OriginalPaperLogTypeBL.GetObjByLogTypeId(strLogTypeId);
clsgs_OriginalPaperLogTypeENEx objgs_OriginalPaperLogTypeENEx = new clsgs_OriginalPaperLogTypeENEx();
clsgs_OriginalPaperLogTypeBL.CopyTo(objgs_OriginalPaperLogTypeEN, objgs_OriginalPaperLogTypeENEx);
return objgs_OriginalPaperLogTypeENEx;
}
}
}