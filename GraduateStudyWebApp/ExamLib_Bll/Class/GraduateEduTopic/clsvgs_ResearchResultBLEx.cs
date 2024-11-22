
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_ResearchResultBLEx
 表名:vgs_ResearchResult(01120778)
 生成代码版本:2020.12.17.1
 生成日期:2020/12/22 19:49:41
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题
 模块英文名:GraduateEduTopic
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
public static class clsvgs_ResearchResultBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_ResearchResultENS">源对象</param>
 /// <returns>目标对象=>clsvgs_ResearchResultEN:objvgs_ResearchResultENT</returns>
 public static clsvgs_ResearchResultENEx CopyToEx(this clsvgs_ResearchResultEN objvgs_ResearchResultENS)
{
try
{
 clsvgs_ResearchResultENEx objvgs_ResearchResultENT = new clsvgs_ResearchResultENEx();
clsvgs_ResearchResultBL.vgs_ResearchResultDA.CopyTo(objvgs_ResearchResultENS, objvgs_ResearchResultENT);
 return objvgs_ResearchResultENT;
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
 /// <param name = "objvgs_ResearchResultENS">源对象</param>
 /// <returns>目标对象=>clsvgs_ResearchResultEN:objvgs_ResearchResultENT</returns>
 public static clsvgs_ResearchResultEN CopyTo(this clsvgs_ResearchResultENEx objvgs_ResearchResultENS)
{
try
{
 clsvgs_ResearchResultEN objvgs_ResearchResultENT = new clsvgs_ResearchResultEN();
clsvgs_ResearchResultBL.CopyTo(objvgs_ResearchResultENS, objvgs_ResearchResultENT);
 return objvgs_ResearchResultENT;
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
 /// 研究成果视图(vgs_ResearchResult)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_ResearchResultBLEx : clsvgs_ResearchResultBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_ResearchResultDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_ResearchResultDAEx vgs_ResearchResultDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_ResearchResultDAEx();
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
public static List<clsvgs_ResearchResultENEx> GetObjExLst(string strCondition)
{
List <clsvgs_ResearchResultEN> arrObjLst = clsvgs_ResearchResultBL.GetObjLst(strCondition);
List <clsvgs_ResearchResultENEx> arrObjExLst = new List<clsvgs_ResearchResultENEx>();
foreach (clsvgs_ResearchResultEN objInFor in arrObjLst)
{
clsvgs_ResearchResultENEx objvgs_ResearchResultENEx = new clsvgs_ResearchResultENEx();
clsvgs_ResearchResultBL.CopyTo(objInFor, objvgs_ResearchResultENEx);
arrObjExLst.Add(objvgs_ResearchResultENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strResultId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_ResearchResultENEx GetObjExByResultId(string strResultId)
{
clsvgs_ResearchResultEN objvgs_ResearchResultEN = clsvgs_ResearchResultBL.GetObjByResultId(strResultId);
clsvgs_ResearchResultENEx objvgs_ResearchResultENEx = new clsvgs_ResearchResultENEx();
clsvgs_ResearchResultBL.CopyTo(objvgs_ResearchResultEN, objvgs_ResearchResultENEx);
return objvgs_ResearchResultENEx;
}
}
}