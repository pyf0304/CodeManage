
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PConceptRelaBLEx
 表名:vgs_PConceptRela(01120668)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/12 23:27:37
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
public static class clsvgs_PConceptRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PConceptRelaEN:objvgs_PConceptRelaENT</returns>
 public static clsvgs_PConceptRelaENEx CopyToEx(this clsvgs_PConceptRelaEN objvgs_PConceptRelaENS)
{
try
{
 clsvgs_PConceptRelaENEx objvgs_PConceptRelaENT = new clsvgs_PConceptRelaENEx();
clsvgs_PConceptRelaBL.vgs_PConceptRelaDA.CopyTo(objvgs_PConceptRelaENS, objvgs_PConceptRelaENT);
 return objvgs_PConceptRelaENT;
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
 /// <param name = "objvgs_PConceptRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PConceptRelaEN:objvgs_PConceptRelaENT</returns>
 public static clsvgs_PConceptRelaEN CopyTo(this clsvgs_PConceptRelaENEx objvgs_PConceptRelaENS)
{
try
{
 clsvgs_PConceptRelaEN objvgs_PConceptRelaENT = new clsvgs_PConceptRelaEN();
clsvgs_PConceptRelaBL.CopyTo(objvgs_PConceptRelaENS, objvgs_PConceptRelaENT);
 return objvgs_PConceptRelaENT;
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
 /// 论文概念关系视图(vgs_PConceptRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvgs_PConceptRelaBLEx : clsvgs_PConceptRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvgs_PConceptRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvgs_PConceptRelaDAEx vgs_PConceptRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvgs_PConceptRelaDAEx();
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
public static List<clsvgs_PConceptRelaENEx> GetObjExLst(string strCondition)
{
List <clsvgs_PConceptRelaEN> arrObjLst = clsvgs_PConceptRelaBL.GetObjLst(strCondition);
List <clsvgs_PConceptRelaENEx> arrObjExLst = new List<clsvgs_PConceptRelaENEx>();
foreach (clsvgs_PConceptRelaEN objInFor in arrObjLst)
{
clsvgs_PConceptRelaENEx objvgs_PConceptRelaENEx = new clsvgs_PConceptRelaENEx();
clsvgs_PConceptRelaBL.CopyTo(objInFor, objvgs_PConceptRelaENEx);
arrObjExLst.Add(objvgs_PConceptRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvgs_PConceptRelaENEx GetObjExBymId(long lngmId)
{
clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = clsvgs_PConceptRelaBL.GetObjBymId(lngmId);
clsvgs_PConceptRelaENEx objvgs_PConceptRelaENEx = new clsvgs_PConceptRelaENEx();
clsvgs_PConceptRelaBL.CopyTo(objvgs_PConceptRelaEN, objvgs_PConceptRelaENEx);
return objvgs_PConceptRelaENEx;
}
}
}