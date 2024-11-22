
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorDirectionBLEx
 表名:vXzMajorDirection(01120553)
 生成代码版本:2020.08.04.1
 生成日期:2020/08/06 14:48:38
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护
 模块英文名:BaseInfo
 框架-层名:业务逻辑扩展层_CS(BusinessLogicEx)
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
public static class clsvXzMajorDirectionBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvXzMajorDirectionENS">源对象</param>
 /// <returns>目标对象=>clsvXzMajorDirectionEN:objvXzMajorDirectionENT</returns>
 public static clsvXzMajorDirectionENEx CopyToEx(this clsvXzMajorDirectionEN objvXzMajorDirectionENS)
{
try
{
 clsvXzMajorDirectionENEx objvXzMajorDirectionENT = new clsvXzMajorDirectionENEx();
clsvXzMajorDirectionBL.vXzMajorDirectionDA.CopyTo(objvXzMajorDirectionENS, objvXzMajorDirectionENT);
 return objvXzMajorDirectionENT;
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
 /// <param name = "objvXzMajorDirectionENS">源对象</param>
 /// <returns>目标对象=>clsvXzMajorDirectionEN:objvXzMajorDirectionENT</returns>
 public static clsvXzMajorDirectionEN CopyTo(this clsvXzMajorDirectionENEx objvXzMajorDirectionENS)
{
try
{
 clsvXzMajorDirectionEN objvXzMajorDirectionENT = new clsvXzMajorDirectionEN();
clsvXzMajorDirectionBL.CopyTo(objvXzMajorDirectionENS, objvXzMajorDirectionENT);
 return objvXzMajorDirectionENT;
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
 /// v专业方向(vXzMajorDirection)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvXzMajorDirectionBLEx : clsvXzMajorDirectionBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvXzMajorDirectionDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvXzMajorDirectionDAEx vXzMajorDirectionDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvXzMajorDirectionDAEx();
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
public static List<clsvXzMajorDirectionENEx> GetObjExLst(string strCondition)
{
List <clsvXzMajorDirectionEN> arrObjLst = clsvXzMajorDirectionBL.GetObjLst(strCondition);
List <clsvXzMajorDirectionENEx> arrObjExLst = new List<clsvXzMajorDirectionENEx>();
foreach (clsvXzMajorDirectionEN objInFor in arrObjLst)
{
clsvXzMajorDirectionENEx objvXzMajorDirectionENEx = new clsvXzMajorDirectionENEx();
clsvXzMajorDirectionBL.CopyTo(objInFor, objvXzMajorDirectionENEx);
arrObjExLst.Add(objvXzMajorDirectionENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvXzMajorDirectionENEx GetObjExByMajorDirectionId(string strMajorDirectionId)
{
clsvXzMajorDirectionEN objvXzMajorDirectionEN = clsvXzMajorDirectionBL.GetObjByMajorDirectionId(strMajorDirectionId);
clsvXzMajorDirectionENEx objvXzMajorDirectionENEx = new clsvXzMajorDirectionENEx();
clsvXzMajorDirectionBL.CopyTo(objvXzMajorDirectionEN, objvXzMajorDirectionENEx);
return objvXzMajorDirectionENEx;
}
}
}