
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PSocialRelaBLEx
 表名:vgs_PSocialRela(01120665)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/12 23:24:50
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
public static class clsvgs_PSocialRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PSocialRelaEN:objvgs_PSocialRelaENT</returns>
 public static clsvgs_PSocialRelaENEx CopyToEx(this clsvgs_PSocialRelaEN objvgs_PSocialRelaENS)
{
try
{
 clsvgs_PSocialRelaENEx objvgs_PSocialRelaENT = new clsvgs_PSocialRelaENEx();
clsvgs_PSocialRelaBL.vgs_PSocialRelaDA.CopyTo(objvgs_PSocialRelaENS, objvgs_PSocialRelaENT);
 return objvgs_PSocialRelaENT;
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
 /// <param name = "objvgs_PSocialRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PSocialRelaEN:objvgs_PSocialRelaENT</returns>
 public static clsvgs_PSocialRelaEN CopyTo(this clsvgs_PSocialRelaENEx objvgs_PSocialRelaENS)
{
try
{
 clsvgs_PSocialRelaEN objvgs_PSocialRelaENT = new clsvgs_PSocialRelaEN();
clsvgs_PSocialRelaBL.CopyTo(objvgs_PSocialRelaENS, objvgs_PSocialRelaENT);
 return objvgs_PSocialRelaENT;
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
 /// 论文社会关系视图(vgs_PSocialRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_PSocialRelaBLEx : clsvgs_PSocialRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_PSocialRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_PSocialRelaDAEx vgs_PSocialRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_PSocialRelaDAEx();
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
public static List<clsvgs_PSocialRelaENEx> GetObjExLst(string strCondition)
{
List <clsvgs_PSocialRelaEN> arrObjLst = clsvgs_PSocialRelaBL.GetObjLst(strCondition);
List <clsvgs_PSocialRelaENEx> arrObjExLst = new List<clsvgs_PSocialRelaENEx>();
foreach (clsvgs_PSocialRelaEN objInFor in arrObjLst)
{
clsvgs_PSocialRelaENEx objvgs_PSocialRelaENEx = new clsvgs_PSocialRelaENEx();
clsvgs_PSocialRelaBL.CopyTo(objInFor, objvgs_PSocialRelaENEx);
arrObjExLst.Add(objvgs_PSocialRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_PSocialRelaENEx GetObjExBymId(long lngmId)
{
clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = clsvgs_PSocialRelaBL.GetObjBymId(lngmId);
clsvgs_PSocialRelaENEx objvgs_PSocialRelaENEx = new clsvgs_PSocialRelaENEx();
clsvgs_PSocialRelaBL.CopyTo(objvgs_PSocialRelaEN, objvgs_PSocialRelaENEx);
return objvgs_PSocialRelaENEx;
}
}
}