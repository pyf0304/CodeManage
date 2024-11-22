
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperDiscussBLEx
 表名:gs_PaperDiscuss(01120681)
 生成代码版本:2020.06.17.1
 生成日期:2020/06/18 16:37:23
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
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
public static class clsgs_PaperDiscussBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PaperDiscussENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperDiscussEN:objgs_PaperDiscussENT</returns>
 public static clsgs_PaperDiscussENEx CopyToEx(this clsgs_PaperDiscussEN objgs_PaperDiscussENS)
{
try
{
 clsgs_PaperDiscussENEx objgs_PaperDiscussENT = new clsgs_PaperDiscussENEx();
clsgs_PaperDiscussBL.gs_PaperDiscussDA.CopyTo(objgs_PaperDiscussENS, objgs_PaperDiscussENT);
 return objgs_PaperDiscussENT;
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
 /// <param name = "objgs_PaperDiscussENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperDiscussEN:objgs_PaperDiscussENT</returns>
 public static clsgs_PaperDiscussEN CopyTo(this clsgs_PaperDiscussENEx objgs_PaperDiscussENS)
{
try
{
 clsgs_PaperDiscussEN objgs_PaperDiscussENT = new clsgs_PaperDiscussEN();
clsgs_PaperDiscussBL.CopyTo(objgs_PaperDiscussENS, objgs_PaperDiscussENT);
 return objgs_PaperDiscussENT;
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
 /// 论文讨论表(gs_PaperDiscuss)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_PaperDiscussBLEx : clsgs_PaperDiscussBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_PaperDiscussDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_PaperDiscussDAEx gs_PaperDiscussDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_PaperDiscussDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PaperDiscussENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperDiscussEN:objgs_PaperDiscussENT</returns>
 public static clsgs_PaperDiscussENEx CopyToEx(clsgs_PaperDiscussEN objgs_PaperDiscussENS)
{
try
{
 clsgs_PaperDiscussENEx objgs_PaperDiscussENT = new clsgs_PaperDiscussENEx();
clsgs_PaperDiscussBL.gs_PaperDiscussDA.CopyTo(objgs_PaperDiscussENS, objgs_PaperDiscussENT);
 return objgs_PaperDiscussENT;
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
public static List<clsgs_PaperDiscussENEx> GetObjExLst(string strCondition)
{
List <clsgs_PaperDiscussEN> arrObjLst = clsgs_PaperDiscussBL.GetObjLst(strCondition);
List <clsgs_PaperDiscussENEx> arrObjExLst = new List<clsgs_PaperDiscussENEx>();
foreach (clsgs_PaperDiscussEN objInFor in arrObjLst)
{
clsgs_PaperDiscussENEx objgs_PaperDiscussENEx = new clsgs_PaperDiscussENEx();
clsgs_PaperDiscussBL.CopyTo(objInFor, objgs_PaperDiscussENEx);
arrObjExLst.Add(objgs_PaperDiscussENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strDiscussId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_PaperDiscussENEx GetObjExByDiscussId(string strDiscussId)
{
clsgs_PaperDiscussEN objgs_PaperDiscussEN = clsgs_PaperDiscussBL.GetObjByDiscussId(strDiscussId);
clsgs_PaperDiscussENEx objgs_PaperDiscussENEx = new clsgs_PaperDiscussENEx();
clsgs_PaperDiscussBL.CopyTo(objgs_PaperDiscussEN, objgs_PaperDiscussENEx);
return objgs_PaperDiscussENEx;
}
}
}