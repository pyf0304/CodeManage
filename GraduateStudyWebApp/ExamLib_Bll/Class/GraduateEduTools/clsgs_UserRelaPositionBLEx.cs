
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_UserRelaPositionBLEx
 表名:gs_UserRelaPosition(01120844)
 生成代码版本:2020.12.30.1
 生成日期:2020/12/30 15:31:32
 生成者:yy
 生成服务器IP:192.168.1.10
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
public static class clsgs_UserRelaPositionBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_UserRelaPositionENS">源对象</param>
 /// <returns>目标对象=>clsgs_UserRelaPositionEN:objgs_UserRelaPositionENT</returns>
 public static clsgs_UserRelaPositionENEx CopyToEx(this clsgs_UserRelaPositionEN objgs_UserRelaPositionENS)
{
try
{
 clsgs_UserRelaPositionENEx objgs_UserRelaPositionENT = new clsgs_UserRelaPositionENEx();
clsgs_UserRelaPositionBL.gs_UserRelaPositionDA.CopyTo(objgs_UserRelaPositionENS, objgs_UserRelaPositionENT);
 return objgs_UserRelaPositionENT;
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
 /// <param name = "objgs_UserRelaPositionENS">源对象</param>
 /// <returns>目标对象=>clsgs_UserRelaPositionEN:objgs_UserRelaPositionENT</returns>
 public static clsgs_UserRelaPositionEN CopyTo(this clsgs_UserRelaPositionENEx objgs_UserRelaPositionENS)
{
try
{
 clsgs_UserRelaPositionEN objgs_UserRelaPositionENT = new clsgs_UserRelaPositionEN();
clsgs_UserRelaPositionBL.CopyTo(objgs_UserRelaPositionENS, objgs_UserRelaPositionENT);
 return objgs_UserRelaPositionENT;
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
 /// 用户关系坐标位置(gs_UserRelaPosition)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_UserRelaPositionBLEx : clsgs_UserRelaPositionBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_UserRelaPositionDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_UserRelaPositionDAEx gs_UserRelaPositionDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_UserRelaPositionDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_UserRelaPositionENS">源对象</param>
 /// <returns>目标对象=>clsgs_UserRelaPositionEN:objgs_UserRelaPositionENT</returns>
 public static clsgs_UserRelaPositionENEx CopyToEx(clsgs_UserRelaPositionEN objgs_UserRelaPositionENS)
{
try
{
 clsgs_UserRelaPositionENEx objgs_UserRelaPositionENT = new clsgs_UserRelaPositionENEx();
clsgs_UserRelaPositionBL.gs_UserRelaPositionDA.CopyTo(objgs_UserRelaPositionENS, objgs_UserRelaPositionENT);
 return objgs_UserRelaPositionENT;
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
public static List<clsgs_UserRelaPositionENEx> GetObjExLst(string strCondition)
{
List <clsgs_UserRelaPositionEN> arrObjLst = clsgs_UserRelaPositionBL.GetObjLst(strCondition);
List <clsgs_UserRelaPositionENEx> arrObjExLst = new List<clsgs_UserRelaPositionENEx>();
foreach (clsgs_UserRelaPositionEN objInFor in arrObjLst)
{
clsgs_UserRelaPositionENEx objgs_UserRelaPositionENEx = new clsgs_UserRelaPositionENEx();
clsgs_UserRelaPositionBL.CopyTo(objInFor, objgs_UserRelaPositionENEx);
arrObjExLst.Add(objgs_UserRelaPositionENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_UserRelaPositionENEx GetObjExBymId(long lngmId)
{
clsgs_UserRelaPositionEN objgs_UserRelaPositionEN = clsgs_UserRelaPositionBL.GetObjBymId(lngmId);
clsgs_UserRelaPositionENEx objgs_UserRelaPositionENEx = new clsgs_UserRelaPositionENEx();
clsgs_UserRelaPositionBL.CopyTo(objgs_UserRelaPositionEN, objgs_UserRelaPositionENEx);
return objgs_UserRelaPositionENEx;
}
}
}