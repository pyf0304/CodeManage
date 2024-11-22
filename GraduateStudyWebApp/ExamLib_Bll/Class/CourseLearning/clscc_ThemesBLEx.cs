
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ThemesBLEx
 表名:cc_Themes(01120069)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 14:50:31
 生成者:pyf2
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clscc_ThemesBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcc_ThemesENS">源对象</param>
 /// <returns>目标对象=>clscc_ThemesEN:objcc_ThemesENT</returns>
 public static clscc_ThemesENEx CopyToEx(this clscc_ThemesEN objcc_ThemesENS)
{
try
{
 clscc_ThemesENEx objcc_ThemesENT = new clscc_ThemesENEx();
clscc_ThemesBL.cc_ThemesDA.CopyTo(objcc_ThemesENS, objcc_ThemesENT);
 return objcc_ThemesENT;
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
 /// <param name = "objcc_ThemesENS">源对象</param>
 /// <returns>目标对象=>clscc_ThemesEN:objcc_ThemesENT</returns>
 public static clscc_ThemesEN CopyTo(this clscc_ThemesENEx objcc_ThemesENS)
{
try
{
 clscc_ThemesEN objcc_ThemesENT = new clscc_ThemesEN();
clscc_ThemesBL.CopyTo(objcc_ThemesENS, objcc_ThemesENT);
 return objcc_ThemesENT;
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
 /// 课程主题(cc_Themes)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscc_ThemesBLEx : clscc_ThemesBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscc_ThemesDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscc_ThemesDAEx cc_ThemesDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscc_ThemesDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcc_ThemesENS">源对象</param>
 /// <returns>目标对象=>clscc_ThemesEN:objcc_ThemesENT</returns>
 public static clscc_ThemesENEx CopyToEx(clscc_ThemesEN objcc_ThemesENS)
{
try
{
 clscc_ThemesENEx objcc_ThemesENT = new clscc_ThemesENEx();
clscc_ThemesBL.cc_ThemesDA.CopyTo(objcc_ThemesENS, objcc_ThemesENT);
 return objcc_ThemesENT;
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
public static List<clscc_ThemesENEx> GetObjExLst(string strCondition)
{
List <clscc_ThemesEN> arrObjLst = clscc_ThemesBL.GetObjLst(strCondition);
List <clscc_ThemesENEx> arrObjExLst = new List<clscc_ThemesENEx>();
foreach (clscc_ThemesEN objInFor in arrObjLst)
{
clscc_ThemesENEx objcc_ThemesENEx = new clscc_ThemesENEx();
clscc_ThemesBL.CopyTo(objInFor, objcc_ThemesENEx);
arrObjExLst.Add(objcc_ThemesENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strThemeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscc_ThemesENEx GetObjExByThemeId(string strThemeId)
{
clscc_ThemesEN objcc_ThemesEN = clscc_ThemesBL.GetObjByThemeId(strThemeId);
clscc_ThemesENEx objcc_ThemesENEx = new clscc_ThemesENEx();
clscc_ThemesBL.CopyTo(objcc_ThemesEN, objcc_ThemesENEx);
return objcc_ThemesENEx;
}
}
}