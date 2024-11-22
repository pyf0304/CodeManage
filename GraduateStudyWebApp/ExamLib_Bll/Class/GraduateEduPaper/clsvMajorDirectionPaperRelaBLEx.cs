
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMajorDirectionPaperRelaBLEx
 表名:vMajorDirectionPaperRela(01120555)
 生成代码版本:2020.02.25.1
 生成日期:2020/02/25 10:33:18
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:研究生培养
 模块英文名:GraduateEdu
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
public static class clsvMajorDirectionPaperRelaBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaENS">源对象</param>
 /// <returns>目标对象=>clsvMajorDirectionPaperRelaEN:objvMajorDirectionPaperRelaENT</returns>
 public static clsvMajorDirectionPaperRelaENEx CopyToEx(this clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaENS)
{
try
{
 clsvMajorDirectionPaperRelaENEx objvMajorDirectionPaperRelaENT = new clsvMajorDirectionPaperRelaENEx();
clsvMajorDirectionPaperRelaBL.vMajorDirectionPaperRelaDA.CopyTo(objvMajorDirectionPaperRelaENS, objvMajorDirectionPaperRelaENT);
 return objvMajorDirectionPaperRelaENT;
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
 /// <param name = "objvMajorDirectionPaperRelaENS">源对象</param>
 /// <returns>目标对象=>clsvMajorDirectionPaperRelaEN:objvMajorDirectionPaperRelaENT</returns>
 public static clsvMajorDirectionPaperRelaEN CopyTo(this clsvMajorDirectionPaperRelaENEx objvMajorDirectionPaperRelaENS)
{
try
{
 clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaENT = new clsvMajorDirectionPaperRelaEN();
clsvMajorDirectionPaperRelaBL.CopyTo(objvMajorDirectionPaperRelaENS, objvMajorDirectionPaperRelaENT);
 return objvMajorDirectionPaperRelaENT;
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
 /// vMajorDirectionPaperRela(vMajorDirectionPaperRela)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvMajorDirectionPaperRelaBLEx : clsvMajorDirectionPaperRelaBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvMajorDirectionPaperRelaDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvMajorDirectionPaperRelaDAEx vMajorDirectionPaperRelaDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvMajorDirectionPaperRelaDAEx();
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
public static List<clsvMajorDirectionPaperRelaENEx> GetObjExLst(string strCondition)
{
List <clsvMajorDirectionPaperRelaEN> arrObjLst = clsvMajorDirectionPaperRelaBL.GetObjLst(strCondition);
List <clsvMajorDirectionPaperRelaENEx> arrObjExLst = new List<clsvMajorDirectionPaperRelaENEx>();
foreach (clsvMajorDirectionPaperRelaEN objInFor in arrObjLst)
{
clsvMajorDirectionPaperRelaENEx objvMajorDirectionPaperRelaENEx = new clsvMajorDirectionPaperRelaENEx();
clsvMajorDirectionPaperRelaBL.CopyTo(objInFor, objvMajorDirectionPaperRelaENEx);
arrObjExLst.Add(objvMajorDirectionPaperRelaENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvMajorDirectionPaperRelaENEx GetObjExBymId(long lngmId)
{
clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = clsvMajorDirectionPaperRelaBL.GetObjBymId(lngmId);
clsvMajorDirectionPaperRelaENEx objvMajorDirectionPaperRelaENEx = new clsvMajorDirectionPaperRelaENEx();
clsvMajorDirectionPaperRelaBL.CopyTo(objvMajorDirectionPaperRelaEN, objvMajorDirectionPaperRelaENEx);
return objvMajorDirectionPaperRelaENEx;
}
}
}