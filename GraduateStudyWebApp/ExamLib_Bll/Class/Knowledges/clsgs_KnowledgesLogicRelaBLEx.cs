
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesLogicRelaBLEx
 表名:gs_KnowledgesLogicRela(01120870)
 生成代码版本:2021.01.18.1
 生成日期:2021/01/25 18:33:53
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
public static class clsgs_KnowledgesLogicRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesLogicRelaEN:objgs_KnowledgesLogicRelaENT</returns>
 public static clsgs_KnowledgesLogicRelaENEx CopyToEx(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaENS)
{
try
{
 clsgs_KnowledgesLogicRelaENEx objgs_KnowledgesLogicRelaENT = new clsgs_KnowledgesLogicRelaENEx();
clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.CopyTo(objgs_KnowledgesLogicRelaENS, objgs_KnowledgesLogicRelaENT);
 return objgs_KnowledgesLogicRelaENT;
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
 /// <param name = "objgs_KnowledgesLogicRelaENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesLogicRelaEN:objgs_KnowledgesLogicRelaENT</returns>
 public static clsgs_KnowledgesLogicRelaEN CopyTo(this clsgs_KnowledgesLogicRelaENEx objgs_KnowledgesLogicRelaENS)
{
try
{
 clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaENT = new clsgs_KnowledgesLogicRelaEN();
clsgs_KnowledgesLogicRelaBL.CopyTo(objgs_KnowledgesLogicRelaENS, objgs_KnowledgesLogicRelaENT);
 return objgs_KnowledgesLogicRelaENT;
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
 /// 知识点逻辑关系表(gs_KnowledgesLogicRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_KnowledgesLogicRelaBLEx : clsgs_KnowledgesLogicRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_KnowledgesLogicRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_KnowledgesLogicRelaDAEx gs_KnowledgesLogicRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_KnowledgesLogicRelaDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesLogicRelaEN:objgs_KnowledgesLogicRelaENT</returns>
 public static clsgs_KnowledgesLogicRelaENEx CopyToEx(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaENS)
{
try
{
 clsgs_KnowledgesLogicRelaENEx objgs_KnowledgesLogicRelaENT = new clsgs_KnowledgesLogicRelaENEx();
clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.CopyTo(objgs_KnowledgesLogicRelaENS, objgs_KnowledgesLogicRelaENT);
 return objgs_KnowledgesLogicRelaENT;
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
public static List<clsgs_KnowledgesLogicRelaENEx> GetObjExLst(string strCondition)
{
List <clsgs_KnowledgesLogicRelaEN> arrObjLst = clsgs_KnowledgesLogicRelaBL.GetObjLst(strCondition);
List <clsgs_KnowledgesLogicRelaENEx> arrObjExLst = new List<clsgs_KnowledgesLogicRelaENEx>();
foreach (clsgs_KnowledgesLogicRelaEN objInFor in arrObjLst)
{
clsgs_KnowledgesLogicRelaENEx objgs_KnowledgesLogicRelaENEx = new clsgs_KnowledgesLogicRelaENEx();
clsgs_KnowledgesLogicRelaBL.CopyTo(objInFor, objgs_KnowledgesLogicRelaENEx);
arrObjExLst.Add(objgs_KnowledgesLogicRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_KnowledgesLogicRelaENEx GetObjExBymId(long lngmId)
{
clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = clsgs_KnowledgesLogicRelaBL.GetObjBymId(lngmId);
clsgs_KnowledgesLogicRelaENEx objgs_KnowledgesLogicRelaENEx = new clsgs_KnowledgesLogicRelaENEx();
clsgs_KnowledgesLogicRelaBL.CopyTo(objgs_KnowledgesLogicRelaEN, objgs_KnowledgesLogicRelaENEx);
return objgs_KnowledgesLogicRelaENEx;
}
}
}