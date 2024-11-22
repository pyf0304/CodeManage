
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ColorBLEx
 表名:gs_Color(01120751)
 生成代码版本:2020.09.24.1
 生成日期:2020/10/12 15:36:55
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数
 模块英文名:ParameterTable
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
public static class clsgs_ColorBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_ColorENS">源对象</param>
 /// <returns>目标对象=>clsgs_ColorEN:objgs_ColorENT</returns>
 public static clsgs_ColorENEx CopyToEx(this clsgs_ColorEN objgs_ColorENS)
{
try
{
 clsgs_ColorENEx objgs_ColorENT = new clsgs_ColorENEx();
clsgs_ColorBL.gs_ColorDA.CopyTo(objgs_ColorENS, objgs_ColorENT);
 return objgs_ColorENT;
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
 /// <param name = "objgs_ColorENS">源对象</param>
 /// <returns>目标对象=>clsgs_ColorEN:objgs_ColorENT</returns>
 public static clsgs_ColorEN CopyTo(this clsgs_ColorENEx objgs_ColorENS)
{
try
{
 clsgs_ColorEN objgs_ColorENT = new clsgs_ColorEN();
clsgs_ColorBL.CopyTo(objgs_ColorENS, objgs_ColorENT);
 return objgs_ColorENT;
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
 /// 颜色表(gs_Color)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_ColorBLEx : clsgs_ColorBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_ColorDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_ColorDAEx gs_ColorDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_ColorDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_ColorENS">源对象</param>
 /// <returns>目标对象=>clsgs_ColorEN:objgs_ColorENT</returns>
 public static clsgs_ColorENEx CopyToEx(clsgs_ColorEN objgs_ColorENS)
{
try
{
 clsgs_ColorENEx objgs_ColorENT = new clsgs_ColorENEx();
clsgs_ColorBL.gs_ColorDA.CopyTo(objgs_ColorENS, objgs_ColorENT);
 return objgs_ColorENT;
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
public static List<clsgs_ColorENEx> GetObjExLst(string strCondition)
{
List <clsgs_ColorEN> arrObjLst = clsgs_ColorBL.GetObjLst(strCondition);
List <clsgs_ColorENEx> arrObjExLst = new List<clsgs_ColorENEx>();
foreach (clsgs_ColorEN objInFor in arrObjLst)
{
clsgs_ColorENEx objgs_ColorENEx = new clsgs_ColorENEx();
clsgs_ColorBL.CopyTo(objInFor, objgs_ColorENEx);
arrObjExLst.Add(objgs_ColorENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strColorId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_ColorENEx GetObjExByColorId(string strColorId)
{
clsgs_ColorEN objgs_ColorEN = clsgs_ColorBL.GetObjByColorId(strColorId);
clsgs_ColorENEx objgs_ColorENEx = new clsgs_ColorENEx();
clsgs_ColorBL.CopyTo(objgs_ColorEN, objgs_ColorENEx);
return objgs_ColorENEx;
}
}
}