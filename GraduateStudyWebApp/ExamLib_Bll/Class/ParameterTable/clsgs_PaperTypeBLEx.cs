
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperTypeBLEx
 表名:gs_PaperType(01120675)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/12 21:50:37
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
public static class clsgs_PaperTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PaperTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperTypeEN:objgs_PaperTypeENT</returns>
 public static clsgs_PaperTypeENEx CopyToEx(this clsgs_PaperTypeEN objgs_PaperTypeENS)
{
try
{
 clsgs_PaperTypeENEx objgs_PaperTypeENT = new clsgs_PaperTypeENEx();
clsgs_PaperTypeBL.gs_PaperTypeDA.CopyTo(objgs_PaperTypeENS, objgs_PaperTypeENT);
 return objgs_PaperTypeENT;
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
 /// <param name = "objgs_PaperTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperTypeEN:objgs_PaperTypeENT</returns>
 public static clsgs_PaperTypeEN CopyTo(this clsgs_PaperTypeENEx objgs_PaperTypeENS)
{
try
{
 clsgs_PaperTypeEN objgs_PaperTypeENT = new clsgs_PaperTypeEN();
clsgs_PaperTypeBL.CopyTo(objgs_PaperTypeENS, objgs_PaperTypeENT);
 return objgs_PaperTypeENT;
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
 /// 论文类型表(gs_PaperType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_PaperTypeBLEx : clsgs_PaperTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_PaperTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_PaperTypeDAEx gs_PaperTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_PaperTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PaperTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperTypeEN:objgs_PaperTypeENT</returns>
 public static clsgs_PaperTypeENEx CopyToEx(clsgs_PaperTypeEN objgs_PaperTypeENS)
{
try
{
 clsgs_PaperTypeENEx objgs_PaperTypeENT = new clsgs_PaperTypeENEx();
clsgs_PaperTypeBL.gs_PaperTypeDA.CopyTo(objgs_PaperTypeENS, objgs_PaperTypeENT);
 return objgs_PaperTypeENT;
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
public static List<clsgs_PaperTypeENEx> GetObjExLst(string strCondition)
{
List <clsgs_PaperTypeEN> arrObjLst = clsgs_PaperTypeBL.GetObjLst(strCondition);
List <clsgs_PaperTypeENEx> arrObjExLst = new List<clsgs_PaperTypeENEx>();
foreach (clsgs_PaperTypeEN objInFor in arrObjLst)
{
clsgs_PaperTypeENEx objgs_PaperTypeENEx = new clsgs_PaperTypeENEx();
clsgs_PaperTypeBL.CopyTo(objInFor, objgs_PaperTypeENEx);
arrObjExLst.Add(objgs_PaperTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strPaperTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_PaperTypeENEx GetObjExByPaperTypeId(string strPaperTypeId)
{
clsgs_PaperTypeEN objgs_PaperTypeEN = clsgs_PaperTypeBL.GetObjByPaperTypeId(strPaperTypeId);
clsgs_PaperTypeENEx objgs_PaperTypeENEx = new clsgs_PaperTypeENEx();
clsgs_PaperTypeBL.CopyTo(objgs_PaperTypeEN, objgs_PaperTypeENEx);
return objgs_PaperTypeENEx;
}
}
}