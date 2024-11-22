
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ColorBLEx
 表名:zx_Color(01120758)
 生成代码版本:2020.09.24.1
 生成日期:2020/11/08 00:56:35
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生参数
 模块英文名:ZxParameter
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
public static class clszx_ColorBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ColorENS">源对象</param>
 /// <returns>目标对象=>clszx_ColorEN:objzx_ColorENT</returns>
 public static clszx_ColorENEx CopyToEx(this clszx_ColorEN objzx_ColorENS)
{
try
{
 clszx_ColorENEx objzx_ColorENT = new clszx_ColorENEx();
clszx_ColorBL.zx_ColorDA.CopyTo(objzx_ColorENS, objzx_ColorENT);
 return objzx_ColorENT;
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
 /// <param name = "objzx_ColorENS">源对象</param>
 /// <returns>目标对象=>clszx_ColorEN:objzx_ColorENT</returns>
 public static clszx_ColorEN CopyTo(this clszx_ColorENEx objzx_ColorENS)
{
try
{
 clszx_ColorEN objzx_ColorENT = new clszx_ColorEN();
clszx_ColorBL.CopyTo(objzx_ColorENS, objzx_ColorENT);
 return objzx_ColorENT;
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
 /// 颜色表(zx_Color)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_ColorBLEx : clszx_ColorBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_ColorDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_ColorDAEx zx_ColorDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_ColorDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ColorENS">源对象</param>
 /// <returns>目标对象=>clszx_ColorEN:objzx_ColorENT</returns>
 public static clszx_ColorENEx CopyToEx(clszx_ColorEN objzx_ColorENS)
{
try
{
 clszx_ColorENEx objzx_ColorENT = new clszx_ColorENEx();
clszx_ColorBL.zx_ColorDA.CopyTo(objzx_ColorENS, objzx_ColorENT);
 return objzx_ColorENT;
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
public static List<clszx_ColorENEx> GetObjExLst(string strCondition)
{
List <clszx_ColorEN> arrObjLst = clszx_ColorBL.GetObjLst(strCondition);
List <clszx_ColorENEx> arrObjExLst = new List<clszx_ColorENEx>();
foreach (clszx_ColorEN objInFor in arrObjLst)
{
clszx_ColorENEx objzx_ColorENEx = new clszx_ColorENEx();
clszx_ColorBL.CopyTo(objInFor, objzx_ColorENEx);
arrObjExLst.Add(objzx_ColorENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strColorId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_ColorENEx GetObjExByColorId(string strColorId)
{
clszx_ColorEN objzx_ColorEN = clszx_ColorBL.GetObjByzxColorId(strColorId);
clszx_ColorENEx objzx_ColorENEx = new clszx_ColorENEx();
clszx_ColorBL.CopyTo(objzx_ColorEN, objzx_ColorENEx);
return objzx_ColorENEx;
}
}
}