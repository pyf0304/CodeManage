
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesGraphTypeBLEx
 表名:gs_KnowledgesGraphType(01120888)
 生成代码版本:2021.03.01.1
 生成日期:2021/03/02 18:07:14
 生成者:yy
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
public static class clsgs_KnowledgesGraphTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesGraphTypeEN:objgs_KnowledgesGraphTypeENT</returns>
 public static clsgs_KnowledgesGraphTypeENEx CopyToEx(this clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeENS)
{
try
{
 clsgs_KnowledgesGraphTypeENEx objgs_KnowledgesGraphTypeENT = new clsgs_KnowledgesGraphTypeENEx();
clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.CopyTo(objgs_KnowledgesGraphTypeENS, objgs_KnowledgesGraphTypeENT);
 return objgs_KnowledgesGraphTypeENT;
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
 /// <param name = "objgs_KnowledgesGraphTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesGraphTypeEN:objgs_KnowledgesGraphTypeENT</returns>
 public static clsgs_KnowledgesGraphTypeEN CopyTo(this clsgs_KnowledgesGraphTypeENEx objgs_KnowledgesGraphTypeENS)
{
try
{
 clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeENT = new clsgs_KnowledgesGraphTypeEN();
clsgs_KnowledgesGraphTypeBL.CopyTo(objgs_KnowledgesGraphTypeENS, objgs_KnowledgesGraphTypeENT);
 return objgs_KnowledgesGraphTypeENT;
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
 /// 知识点图谱类型(gs_KnowledgesGraphType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_KnowledgesGraphTypeBLEx : clsgs_KnowledgesGraphTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_KnowledgesGraphTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_KnowledgesGraphTypeDAEx gs_KnowledgesGraphTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_KnowledgesGraphTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesGraphTypeEN:objgs_KnowledgesGraphTypeENT</returns>
 public static clsgs_KnowledgesGraphTypeENEx CopyToEx(clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeENS)
{
try
{
 clsgs_KnowledgesGraphTypeENEx objgs_KnowledgesGraphTypeENT = new clsgs_KnowledgesGraphTypeENEx();
clsgs_KnowledgesGraphTypeBL.gs_KnowledgesGraphTypeDA.CopyTo(objgs_KnowledgesGraphTypeENS, objgs_KnowledgesGraphTypeENT);
 return objgs_KnowledgesGraphTypeENT;
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
public static List<clsgs_KnowledgesGraphTypeENEx> GetObjExLst(string strCondition)
{
List <clsgs_KnowledgesGraphTypeEN> arrObjLst = clsgs_KnowledgesGraphTypeBL.GetObjLst(strCondition);
List <clsgs_KnowledgesGraphTypeENEx> arrObjExLst = new List<clsgs_KnowledgesGraphTypeENEx>();
foreach (clsgs_KnowledgesGraphTypeEN objInFor in arrObjLst)
{
clsgs_KnowledgesGraphTypeENEx objgs_KnowledgesGraphTypeENEx = new clsgs_KnowledgesGraphTypeENEx();
clsgs_KnowledgesGraphTypeBL.CopyTo(objInFor, objgs_KnowledgesGraphTypeENEx);
arrObjExLst.Add(objgs_KnowledgesGraphTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strGraphTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_KnowledgesGraphTypeENEx GetObjExByGraphTypeId(string strGraphTypeId)
{
clsgs_KnowledgesGraphTypeEN objgs_KnowledgesGraphTypeEN = clsgs_KnowledgesGraphTypeBL.GetObjByGraphTypeId(strGraphTypeId);
clsgs_KnowledgesGraphTypeENEx objgs_KnowledgesGraphTypeENEx = new clsgs_KnowledgesGraphTypeENEx();
clsgs_KnowledgesGraphTypeBL.CopyTo(objgs_KnowledgesGraphTypeEN, objgs_KnowledgesGraphTypeENEx);
return objgs_KnowledgesGraphTypeENEx;
}
}
}