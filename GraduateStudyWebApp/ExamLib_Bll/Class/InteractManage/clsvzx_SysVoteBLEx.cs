
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SysVoteBLEx
 表名:vzx_SysVote(01120853)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:01:46
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsvzx_SysVoteBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_SysVoteENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SysVoteEN:objvzx_SysVoteENT</returns>
 public static clsvzx_SysVoteENEx CopyToEx(this clsvzx_SysVoteEN objvzx_SysVoteENS)
{
try
{
 clsvzx_SysVoteENEx objvzx_SysVoteENT = new clsvzx_SysVoteENEx();
clsvzx_SysVoteBL.vzx_SysVoteDA.CopyTo(objvzx_SysVoteENS, objvzx_SysVoteENT);
 return objvzx_SysVoteENT;
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
 /// <param name = "objvzx_SysVoteENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SysVoteEN:objvzx_SysVoteENT</returns>
 public static clsvzx_SysVoteEN CopyTo(this clsvzx_SysVoteENEx objvzx_SysVoteENS)
{
try
{
 clsvzx_SysVoteEN objvzx_SysVoteENT = new clsvzx_SysVoteEN();
clsvzx_SysVoteBL.CopyTo(objvzx_SysVoteENS, objvzx_SysVoteENT);
 return objvzx_SysVoteENT;
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
 /// vzx_SysVote(vzx_SysVote)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_SysVoteBLEx : clsvzx_SysVoteBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_SysVoteDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_SysVoteDAEx vzx_SysVoteDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_SysVoteDAEx();
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
public static List<clsvzx_SysVoteENEx> GetObjExLst(string strCondition)
{
List <clsvzx_SysVoteEN> arrObjLst = clsvzx_SysVoteBL.GetObjLst(strCondition);
List <clsvzx_SysVoteENEx> arrObjExLst = new List<clsvzx_SysVoteENEx>();
foreach (clsvzx_SysVoteEN objInFor in arrObjLst)
{
clsvzx_SysVoteENEx objvzx_SysVoteENEx = new clsvzx_SysVoteENEx();
clsvzx_SysVoteBL.CopyTo(objInFor, objvzx_SysVoteENEx);
arrObjExLst.Add(objvzx_SysVoteENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngzxVoteId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_SysVoteENEx GetObjExByzxVoteId(long lngzxVoteId)
{
clsvzx_SysVoteEN objvzx_SysVoteEN = clsvzx_SysVoteBL.GetObjByzxVoteId(lngzxVoteId);
clsvzx_SysVoteENEx objvzx_SysVoteENEx = new clsvzx_SysVoteENEx();
clsvzx_SysVoteBL.CopyTo(objvzx_SysVoteEN, objvzx_SysVoteENEx);
return objvzx_SysVoteENEx;
}
}
}