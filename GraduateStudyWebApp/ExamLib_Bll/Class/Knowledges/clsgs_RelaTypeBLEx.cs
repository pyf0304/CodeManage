
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_RelaTypeBLEx
 表名:gs_RelaType(01120871)
 生成代码版本:2021.01.18.1
 生成日期:2021/01/25 18:35:35
 生成者:lyl
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsgs_RelaTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_RelaTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_RelaTypeEN:objgs_RelaTypeENT</returns>
 public static clsgs_RelaTypeENEx CopyToEx(this clsgs_RelaTypeEN objgs_RelaTypeENS)
{
try
{
 clsgs_RelaTypeENEx objgs_RelaTypeENT = new clsgs_RelaTypeENEx();
clsgs_RelaTypeBL.gs_RelaTypeDA.CopyTo(objgs_RelaTypeENS, objgs_RelaTypeENT);
 return objgs_RelaTypeENT;
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
 /// <param name = "objgs_RelaTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_RelaTypeEN:objgs_RelaTypeENT</returns>
 public static clsgs_RelaTypeEN CopyTo(this clsgs_RelaTypeENEx objgs_RelaTypeENS)
{
try
{
 clsgs_RelaTypeEN objgs_RelaTypeENT = new clsgs_RelaTypeEN();
clsgs_RelaTypeBL.CopyTo(objgs_RelaTypeENS, objgs_RelaTypeENT);
 return objgs_RelaTypeENT;
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
 /// 关系类型表(gs_RelaType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_RelaTypeBLEx : clsgs_RelaTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_RelaTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_RelaTypeDAEx gs_RelaTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_RelaTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_RelaTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_RelaTypeEN:objgs_RelaTypeENT</returns>
 public static clsgs_RelaTypeENEx CopyToEx(clsgs_RelaTypeEN objgs_RelaTypeENS)
{
try
{
 clsgs_RelaTypeENEx objgs_RelaTypeENT = new clsgs_RelaTypeENEx();
clsgs_RelaTypeBL.gs_RelaTypeDA.CopyTo(objgs_RelaTypeENS, objgs_RelaTypeENT);
 return objgs_RelaTypeENT;
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
public static List<clsgs_RelaTypeENEx> GetObjExLst(string strCondition)
{
List <clsgs_RelaTypeEN> arrObjLst = clsgs_RelaTypeBL.GetObjLst(strCondition);
List <clsgs_RelaTypeENEx> arrObjExLst = new List<clsgs_RelaTypeENEx>();
foreach (clsgs_RelaTypeEN objInFor in arrObjLst)
{
clsgs_RelaTypeENEx objgs_RelaTypeENEx = new clsgs_RelaTypeENEx();
clsgs_RelaTypeBL.CopyTo(objInFor, objgs_RelaTypeENEx);
arrObjExLst.Add(objgs_RelaTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strRelaTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_RelaTypeENEx GetObjExByRelaTypeId(string strRelaTypeId)
{
clsgs_RelaTypeEN objgs_RelaTypeEN = clsgs_RelaTypeBL.GetObjByRelaTypeId(strRelaTypeId);
clsgs_RelaTypeENEx objgs_RelaTypeENEx = new clsgs_RelaTypeENEx();
clsgs_RelaTypeBL.CopyTo(objgs_RelaTypeEN, objgs_RelaTypeENEx);
return objgs_RelaTypeENEx;
}
}
}