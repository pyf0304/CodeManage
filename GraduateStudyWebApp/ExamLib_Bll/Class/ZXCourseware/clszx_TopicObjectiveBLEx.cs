
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicObjectiveBLEx
 表名:zx_TopicObjective(01120708)
 生成代码版本:2020.07.31.1
 生成日期:2020/08/03 09:32:12
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:中学生课件管理
 模块英文名:ZXCourseware
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
public static class clszx_TopicObjectiveBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveENS">源对象</param>
 /// <returns>目标对象=>clszx_TopicObjectiveEN:objzx_TopicObjectiveENT</returns>
 public static clszx_TopicObjectiveENEx CopyToEx(this clszx_TopicObjectiveEN objzx_TopicObjectiveENS)
{
try
{
 clszx_TopicObjectiveENEx objzx_TopicObjectiveENT = new clszx_TopicObjectiveENEx();
clszx_TopicObjectiveBL.zx_TopicObjectiveDA.CopyTo(objzx_TopicObjectiveENS, objzx_TopicObjectiveENT);
 return objzx_TopicObjectiveENT;
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
 /// <param name = "objzx_TopicObjectiveENS">源对象</param>
 /// <returns>目标对象=>clszx_TopicObjectiveEN:objzx_TopicObjectiveENT</returns>
 public static clszx_TopicObjectiveEN CopyTo(this clszx_TopicObjectiveENEx objzx_TopicObjectiveENS)
{
try
{
 clszx_TopicObjectiveEN objzx_TopicObjectiveENT = new clszx_TopicObjectiveEN();
clszx_TopicObjectiveBL.CopyTo(objzx_TopicObjectiveENS, objzx_TopicObjectiveENT);
 return objzx_TopicObjectiveENT;
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
 /// 中学客观事实数据(zx_TopicObjective)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_TopicObjectiveBLEx : clszx_TopicObjectiveBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_TopicObjectiveDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_TopicObjectiveDAEx zx_TopicObjectiveDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_TopicObjectiveDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveENS">源对象</param>
 /// <returns>目标对象=>clszx_TopicObjectiveEN:objzx_TopicObjectiveENT</returns>
 public static clszx_TopicObjectiveENEx CopyToEx(clszx_TopicObjectiveEN objzx_TopicObjectiveENS)
{
try
{
 clszx_TopicObjectiveENEx objzx_TopicObjectiveENT = new clszx_TopicObjectiveENEx();
clszx_TopicObjectiveBL.zx_TopicObjectiveDA.CopyTo(objzx_TopicObjectiveENS, objzx_TopicObjectiveENT);
 return objzx_TopicObjectiveENT;
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
public static List<clszx_TopicObjectiveENEx> GetObjExLst(string strCondition)
{
List <clszx_TopicObjectiveEN> arrObjLst = clszx_TopicObjectiveBL.GetObjLst(strCondition);
List <clszx_TopicObjectiveENEx> arrObjExLst = new List<clszx_TopicObjectiveENEx>();
foreach (clszx_TopicObjectiveEN objInFor in arrObjLst)
{
clszx_TopicObjectiveENEx objzx_TopicObjectiveENEx = new clszx_TopicObjectiveENEx();
clszx_TopicObjectiveBL.CopyTo(objInFor, objzx_TopicObjectiveENEx);
arrObjExLst.Add(objzx_TopicObjectiveENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTopicObjectiveId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_TopicObjectiveENEx GetObjExByTopicObjectiveId(string strTopicObjectiveId)
{
clszx_TopicObjectiveEN objzx_TopicObjectiveEN = clszx_TopicObjectiveBL.GetObjByzxTopicObjectiveId(strTopicObjectiveId);
clszx_TopicObjectiveENEx objzx_TopicObjectiveENEx = new clszx_TopicObjectiveENEx();
clszx_TopicObjectiveBL.CopyTo(objzx_TopicObjectiveEN, objzx_TopicObjectiveENEx);
return objzx_TopicObjectiveENEx;
}
}
}