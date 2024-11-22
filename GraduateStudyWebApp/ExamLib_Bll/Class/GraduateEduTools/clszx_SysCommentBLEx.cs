
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysCommentBLEx
 表名:zx_SysComment(01120795)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:58:28
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置
 模块英文名:GraduateEduTools
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
public static class clszx_SysCommentBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SysCommentENS">源对象</param>
 /// <returns>目标对象=>clszx_SysCommentEN:objzx_SysCommentENT</returns>
 public static clszx_SysCommentENEx CopyToEx(this clszx_SysCommentEN objzx_SysCommentENS)
{
try
{
 clszx_SysCommentENEx objzx_SysCommentENT = new clszx_SysCommentENEx();
clszx_SysCommentBL.zx_SysCommentDA.CopyTo(objzx_SysCommentENS, objzx_SysCommentENT);
 return objzx_SysCommentENT;
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
 /// <param name = "objzx_SysCommentENS">源对象</param>
 /// <returns>目标对象=>clszx_SysCommentEN:objzx_SysCommentENT</returns>
 public static clszx_SysCommentEN CopyTo(this clszx_SysCommentENEx objzx_SysCommentENS)
{
try
{
 clszx_SysCommentEN objzx_SysCommentENT = new clszx_SysCommentEN();
clszx_SysCommentBL.CopyTo(objzx_SysCommentENS, objzx_SysCommentENT);
 return objzx_SysCommentENT;
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
 /// 中学系统评论表(zx_SysComment)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_SysCommentBLEx : clszx_SysCommentBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_SysCommentDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_SysCommentDAEx zx_SysCommentDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_SysCommentDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SysCommentENS">源对象</param>
 /// <returns>目标对象=>clszx_SysCommentEN:objzx_SysCommentENT</returns>
 public static clszx_SysCommentENEx CopyToEx(clszx_SysCommentEN objzx_SysCommentENS)
{
try
{
 clszx_SysCommentENEx objzx_SysCommentENT = new clszx_SysCommentENEx();
clszx_SysCommentBL.zx_SysCommentDA.CopyTo(objzx_SysCommentENS, objzx_SysCommentENT);
 return objzx_SysCommentENT;
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
public static List<clszx_SysCommentENEx> GetObjExLst(string strCondition)
{
List <clszx_SysCommentEN> arrObjLst = clszx_SysCommentBL.GetObjLst(strCondition);
List <clszx_SysCommentENEx> arrObjExLst = new List<clszx_SysCommentENEx>();
foreach (clszx_SysCommentEN objInFor in arrObjLst)
{
clszx_SysCommentENEx objzx_SysCommentENEx = new clszx_SysCommentENEx();
clszx_SysCommentBL.CopyTo(objInFor, objzx_SysCommentENEx);
arrObjExLst.Add(objzx_SysCommentENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxCommentId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_SysCommentENEx GetObjExByzxCommentId(string strzxCommentId)
{
clszx_SysCommentEN objzx_SysCommentEN = clszx_SysCommentBL.GetObjByzxCommentId(strzxCommentId);
clszx_SysCommentENEx objzx_SysCommentENEx = new clszx_SysCommentENEx();
clszx_SysCommentBL.CopyTo(objzx_SysCommentEN, objzx_SysCommentENEx);
return objzx_SysCommentENEx;
}
}
}