
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SysCountBLEx
 表名:vzx_SysCount(01120837)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/14 23:58:52
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
public static class clsvzx_SysCountBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_SysCountENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SysCountEN:objvzx_SysCountENT</returns>
 public static clsvzx_SysCountENEx CopyToEx(this clsvzx_SysCountEN objvzx_SysCountENS)
{
try
{
 clsvzx_SysCountENEx objvzx_SysCountENT = new clsvzx_SysCountENEx();
clsvzx_SysCountBL.vzx_SysCountDA.CopyTo(objvzx_SysCountENS, objvzx_SysCountENT);
 return objvzx_SysCountENT;
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
 /// <param name = "objvzx_SysCountENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SysCountEN:objvzx_SysCountENT</returns>
 public static clsvzx_SysCountEN CopyTo(this clsvzx_SysCountENEx objvzx_SysCountENS)
{
try
{
 clsvzx_SysCountEN objvzx_SysCountENT = new clsvzx_SysCountEN();
clsvzx_SysCountBL.CopyTo(objvzx_SysCountENS, objvzx_SysCountENT);
 return objvzx_SysCountENT;
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
 /// vzx_SysCount(vzx_SysCount)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_SysCountBLEx : clsvzx_SysCountBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_SysCountDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_SysCountDAEx vzx_SysCountDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_SysCountDAEx();
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
public static List<clsvzx_SysCountENEx> GetObjExLst(string strCondition)
{
List <clsvzx_SysCountEN> arrObjLst = clsvzx_SysCountBL.GetObjLst(strCondition);
List <clsvzx_SysCountENEx> arrObjExLst = new List<clsvzx_SysCountENEx>();
foreach (clsvzx_SysCountEN objInFor in arrObjLst)
{
clsvzx_SysCountENEx objvzx_SysCountENEx = new clsvzx_SysCountENEx();
clsvzx_SysCountBL.CopyTo(objInFor, objvzx_SysCountENEx);
arrObjExLst.Add(objvzx_SysCountENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxCountId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_SysCountENEx GetObjExByzxCountId(string strzxCountId)
{
clsvzx_SysCountEN objvzx_SysCountEN = clsvzx_SysCountBL.GetObjByzxCountId(strzxCountId);
clsvzx_SysCountENEx objvzx_SysCountENEx = new clsvzx_SysCountENEx();
clsvzx_SysCountBL.CopyTo(objvzx_SysCountEN, objvzx_SysCountENEx);
return objvzx_SysCountENEx;
}
}
}