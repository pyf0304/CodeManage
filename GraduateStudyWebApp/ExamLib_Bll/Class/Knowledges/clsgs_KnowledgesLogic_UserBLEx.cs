
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesLogic_UserBLEx
 表名:gs_KnowledgesLogic_User(01120889)
 生成代码版本:2021.03.04.1
 生成日期:2021/03/05 22:06:03
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
public static class clsgs_KnowledgesLogic_UserBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogic_UserENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesLogic_UserEN:objgs_KnowledgesLogic_UserENT</returns>
 public static clsgs_KnowledgesLogic_UserENEx CopyToEx(this clsgs_KnowledgesLogic_UserEN objgs_KnowledgesLogic_UserENS)
{
try
{
 clsgs_KnowledgesLogic_UserENEx objgs_KnowledgesLogic_UserENT = new clsgs_KnowledgesLogic_UserENEx();
clsgs_KnowledgesLogic_UserBL.gs_KnowledgesLogic_UserDA.CopyTo(objgs_KnowledgesLogic_UserENS, objgs_KnowledgesLogic_UserENT);
 return objgs_KnowledgesLogic_UserENT;
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
 /// <param name = "objgs_KnowledgesLogic_UserENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesLogic_UserEN:objgs_KnowledgesLogic_UserENT</returns>
 public static clsgs_KnowledgesLogic_UserEN CopyTo(this clsgs_KnowledgesLogic_UserENEx objgs_KnowledgesLogic_UserENS)
{
try
{
 clsgs_KnowledgesLogic_UserEN objgs_KnowledgesLogic_UserENT = new clsgs_KnowledgesLogic_UserEN();
clsgs_KnowledgesLogic_UserBL.CopyTo(objgs_KnowledgesLogic_UserENS, objgs_KnowledgesLogic_UserENT);
 return objgs_KnowledgesLogic_UserENT;
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
 /// 知识点逻辑点_个性化用户(gs_KnowledgesLogic_User)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_KnowledgesLogic_UserBLEx : clsgs_KnowledgesLogic_UserBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_KnowledgesLogic_UserDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_KnowledgesLogic_UserDAEx gs_KnowledgesLogic_UserDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_KnowledgesLogic_UserDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogic_UserENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesLogic_UserEN:objgs_KnowledgesLogic_UserENT</returns>
 public static clsgs_KnowledgesLogic_UserENEx CopyToEx(clsgs_KnowledgesLogic_UserEN objgs_KnowledgesLogic_UserENS)
{
try
{
 clsgs_KnowledgesLogic_UserENEx objgs_KnowledgesLogic_UserENT = new clsgs_KnowledgesLogic_UserENEx();
clsgs_KnowledgesLogic_UserBL.gs_KnowledgesLogic_UserDA.CopyTo(objgs_KnowledgesLogic_UserENS, objgs_KnowledgesLogic_UserENT);
 return objgs_KnowledgesLogic_UserENT;
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
public static List<clsgs_KnowledgesLogic_UserENEx> GetObjExLst(string strCondition)
{
List <clsgs_KnowledgesLogic_UserEN> arrObjLst = clsgs_KnowledgesLogic_UserBL.GetObjLst(strCondition);
List <clsgs_KnowledgesLogic_UserENEx> arrObjExLst = new List<clsgs_KnowledgesLogic_UserENEx>();
foreach (clsgs_KnowledgesLogic_UserEN objInFor in arrObjLst)
{
clsgs_KnowledgesLogic_UserENEx objgs_KnowledgesLogic_UserENEx = new clsgs_KnowledgesLogic_UserENEx();
clsgs_KnowledgesLogic_UserBL.CopyTo(objInFor, objgs_KnowledgesLogic_UserENEx);
arrObjExLst.Add(objgs_KnowledgesLogic_UserENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_KnowledgesLogic_UserENEx GetObjExBymId(long lngmId)
{
clsgs_KnowledgesLogic_UserEN objgs_KnowledgesLogic_UserEN = clsgs_KnowledgesLogic_UserBL.GetObjBymId(lngmId);
clsgs_KnowledgesLogic_UserENEx objgs_KnowledgesLogic_UserENEx = new clsgs_KnowledgesLogic_UserENEx();
clsgs_KnowledgesLogic_UserBL.CopyTo(objgs_KnowledgesLogic_UserEN, objgs_KnowledgesLogic_UserENEx);
return objgs_KnowledgesLogic_UserENEx;
}
}
}