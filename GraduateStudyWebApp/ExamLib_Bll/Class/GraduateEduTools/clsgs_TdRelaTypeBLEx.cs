
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TdRelaTypeBLEx
 表名:gs_TdRelaType(01120703)
 生成代码版本:2020.07.13.1
 生成日期:2020/07/16 22:57:32
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培设置
 模块英文名:GraduateEduTools
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
public static class clsgs_TdRelaTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_TdRelaTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_TdRelaTypeEN:objgs_TdRelaTypeENT</returns>
 public static clsgs_TdRelaTypeENEx CopyToEx(this clsgs_TdRelaTypeEN objgs_TdRelaTypeENS)
{
try
{
 clsgs_TdRelaTypeENEx objgs_TdRelaTypeENT = new clsgs_TdRelaTypeENEx();
clsgs_TdRelaTypeBL.gs_TdRelaTypeDA.CopyTo(objgs_TdRelaTypeENS, objgs_TdRelaTypeENT);
 return objgs_TdRelaTypeENT;
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
 /// <param name = "objgs_TdRelaTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_TdRelaTypeEN:objgs_TdRelaTypeENT</returns>
 public static clsgs_TdRelaTypeEN CopyTo(this clsgs_TdRelaTypeENEx objgs_TdRelaTypeENS)
{
try
{
 clsgs_TdRelaTypeEN objgs_TdRelaTypeENT = new clsgs_TdRelaTypeEN();
clsgs_TdRelaTypeBL.CopyTo(objgs_TdRelaTypeENS, objgs_TdRelaTypeENT);
 return objgs_TdRelaTypeENT;
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
 /// 总数据关系类型表(gs_TdRelaType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_TdRelaTypeBLEx : clsgs_TdRelaTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_TdRelaTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_TdRelaTypeDAEx gs_TdRelaTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_TdRelaTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_TdRelaTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_TdRelaTypeEN:objgs_TdRelaTypeENT</returns>
 public static clsgs_TdRelaTypeENEx CopyToEx(clsgs_TdRelaTypeEN objgs_TdRelaTypeENS)
{
try
{
 clsgs_TdRelaTypeENEx objgs_TdRelaTypeENT = new clsgs_TdRelaTypeENEx();
clsgs_TdRelaTypeBL.gs_TdRelaTypeDA.CopyTo(objgs_TdRelaTypeENS, objgs_TdRelaTypeENT);
 return objgs_TdRelaTypeENT;
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
public static List<clsgs_TdRelaTypeENEx> GetObjExLst(string strCondition)
{
List <clsgs_TdRelaTypeEN> arrObjLst = clsgs_TdRelaTypeBL.GetObjLst(strCondition);
List <clsgs_TdRelaTypeENEx> arrObjExLst = new List<clsgs_TdRelaTypeENEx>();
foreach (clsgs_TdRelaTypeEN objInFor in arrObjLst)
{
clsgs_TdRelaTypeENEx objgs_TdRelaTypeENEx = new clsgs_TdRelaTypeENEx();
clsgs_TdRelaTypeBL.CopyTo(objInFor, objgs_TdRelaTypeENEx);
arrObjExLst.Add(objgs_TdRelaTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTDRelaTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_TdRelaTypeENEx GetObjExByTdRelaTypeId(string strTDRelaTypeId)
{
clsgs_TdRelaTypeEN objgs_TdRelaTypeEN = clsgs_TdRelaTypeBL.GetObjByTdRelaTypeId(strTDRelaTypeId);
clsgs_TdRelaTypeENEx objgs_TdRelaTypeENEx = new clsgs_TdRelaTypeENEx();
clsgs_TdRelaTypeBL.CopyTo(objgs_TdRelaTypeEN, objgs_TdRelaTypeENEx);
return objgs_TdRelaTypeENEx;
}
}
}