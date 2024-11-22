
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_QuestionsTypeBLEx
 表名:zx_QuestionsType(01120812)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:00:09
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
public static class clszx_QuestionsTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_QuestionsTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_QuestionsTypeEN:objzx_QuestionsTypeENT</returns>
 public static clszx_QuestionsTypeENEx CopyToEx(this clszx_QuestionsTypeEN objzx_QuestionsTypeENS)
{
try
{
 clszx_QuestionsTypeENEx objzx_QuestionsTypeENT = new clszx_QuestionsTypeENEx();
clszx_QuestionsTypeBL.zx_QuestionsTypeDA.CopyTo(objzx_QuestionsTypeENS, objzx_QuestionsTypeENT);
 return objzx_QuestionsTypeENT;
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
 /// <param name = "objzx_QuestionsTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_QuestionsTypeEN:objzx_QuestionsTypeENT</returns>
 public static clszx_QuestionsTypeEN CopyTo(this clszx_QuestionsTypeENEx objzx_QuestionsTypeENS)
{
try
{
 clszx_QuestionsTypeEN objzx_QuestionsTypeENT = new clszx_QuestionsTypeEN();
clszx_QuestionsTypeBL.CopyTo(objzx_QuestionsTypeENS, objzx_QuestionsTypeENT);
 return objzx_QuestionsTypeENT;
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
 /// 中学问题类型表(zx_QuestionsType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_QuestionsTypeBLEx : clszx_QuestionsTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_QuestionsTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_QuestionsTypeDAEx zx_QuestionsTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_QuestionsTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_QuestionsTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_QuestionsTypeEN:objzx_QuestionsTypeENT</returns>
 public static clszx_QuestionsTypeENEx CopyToEx(clszx_QuestionsTypeEN objzx_QuestionsTypeENS)
{
try
{
 clszx_QuestionsTypeENEx objzx_QuestionsTypeENT = new clszx_QuestionsTypeENEx();
clszx_QuestionsTypeBL.zx_QuestionsTypeDA.CopyTo(objzx_QuestionsTypeENS, objzx_QuestionsTypeENT);
 return objzx_QuestionsTypeENT;
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
public static List<clszx_QuestionsTypeENEx> GetObjExLst(string strCondition)
{
List <clszx_QuestionsTypeEN> arrObjLst = clszx_QuestionsTypeBL.GetObjLst(strCondition);
List <clszx_QuestionsTypeENEx> arrObjExLst = new List<clszx_QuestionsTypeENEx>();
foreach (clszx_QuestionsTypeEN objInFor in arrObjLst)
{
clszx_QuestionsTypeENEx objzx_QuestionsTypeENEx = new clszx_QuestionsTypeENEx();
clszx_QuestionsTypeBL.CopyTo(objInFor, objzx_QuestionsTypeENEx);
arrObjExLst.Add(objzx_QuestionsTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxQuestionsTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_QuestionsTypeENEx GetObjExByzxQuestionsTypeId(string strzxQuestionsTypeId)
{
clszx_QuestionsTypeEN objzx_QuestionsTypeEN = clszx_QuestionsTypeBL.GetObjByzxQuestionsTypeId(strzxQuestionsTypeId);
clszx_QuestionsTypeENEx objzx_QuestionsTypeENEx = new clszx_QuestionsTypeENEx();
clszx_QuestionsTypeBL.CopyTo(objzx_QuestionsTypeEN, objzx_QuestionsTypeENEx);
return objzx_QuestionsTypeENEx;
}
}
}