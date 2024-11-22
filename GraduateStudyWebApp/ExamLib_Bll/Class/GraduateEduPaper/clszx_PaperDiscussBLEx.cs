
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_PaperDiscussBLEx
 表名:zx_PaperDiscuss(01120784)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:58:55
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
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
public static class clszx_PaperDiscussBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_PaperDiscussENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperDiscussEN:objzx_PaperDiscussENT</returns>
 public static clszx_PaperDiscussENEx CopyToEx(this clszx_PaperDiscussEN objzx_PaperDiscussENS)
{
try
{
 clszx_PaperDiscussENEx objzx_PaperDiscussENT = new clszx_PaperDiscussENEx();
clszx_PaperDiscussBL.zx_PaperDiscussDA.CopyTo(objzx_PaperDiscussENS, objzx_PaperDiscussENT);
 return objzx_PaperDiscussENT;
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
 /// <param name = "objzx_PaperDiscussENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperDiscussEN:objzx_PaperDiscussENT</returns>
 public static clszx_PaperDiscussEN CopyTo(this clszx_PaperDiscussENEx objzx_PaperDiscussENS)
{
try
{
 clszx_PaperDiscussEN objzx_PaperDiscussENT = new clszx_PaperDiscussEN();
clszx_PaperDiscussBL.CopyTo(objzx_PaperDiscussENS, objzx_PaperDiscussENT);
 return objzx_PaperDiscussENT;
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
 /// 作文讨论表(zx_PaperDiscuss)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_PaperDiscussBLEx : clszx_PaperDiscussBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_PaperDiscussDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_PaperDiscussDAEx zx_PaperDiscussDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_PaperDiscussDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_PaperDiscussENS">源对象</param>
 /// <returns>目标对象=>clszx_PaperDiscussEN:objzx_PaperDiscussENT</returns>
 public static clszx_PaperDiscussENEx CopyToEx(clszx_PaperDiscussEN objzx_PaperDiscussENS)
{
try
{
 clszx_PaperDiscussENEx objzx_PaperDiscussENT = new clszx_PaperDiscussENEx();
clszx_PaperDiscussBL.zx_PaperDiscussDA.CopyTo(objzx_PaperDiscussENS, objzx_PaperDiscussENT);
 return objzx_PaperDiscussENT;
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
public static List<clszx_PaperDiscussENEx> GetObjExLst(string strCondition)
{
List <clszx_PaperDiscussEN> arrObjLst = clszx_PaperDiscussBL.GetObjLst(strCondition);
List <clszx_PaperDiscussENEx> arrObjExLst = new List<clszx_PaperDiscussENEx>();
foreach (clszx_PaperDiscussEN objInFor in arrObjLst)
{
clszx_PaperDiscussENEx objzx_PaperDiscussENEx = new clszx_PaperDiscussENEx();
clszx_PaperDiscussBL.CopyTo(objInFor, objzx_PaperDiscussENEx);
arrObjExLst.Add(objzx_PaperDiscussENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxDiscussId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_PaperDiscussENEx GetObjExByzxDiscussId(string strzxDiscussId)
{
clszx_PaperDiscussEN objzx_PaperDiscussEN = clszx_PaperDiscussBL.GetObjByzxDiscussId(strzxDiscussId);
clszx_PaperDiscussENEx objzx_PaperDiscussENEx = new clszx_PaperDiscussENEx();
clszx_PaperDiscussBL.CopyTo(objzx_PaperDiscussEN, objzx_PaperDiscussENEx);
return objzx_PaperDiscussENEx;
}
}
}