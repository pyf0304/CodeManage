
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ConceptBLEx
 表名:zx_Concept(01120709)
 生成代码版本:2020.07.31.1
 生成日期:2020/08/03 09:32:07
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:中学生课件管理
 模块英文名:ZXCourseware
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
public static class clszx_ConceptBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ConceptENS">源对象</param>
 /// <returns>目标对象=>clszx_ConceptEN:objzx_ConceptENT</returns>
 public static clszx_ConceptENEx CopyToEx(this clszx_ConceptEN objzx_ConceptENS)
{
try
{
 clszx_ConceptENEx objzx_ConceptENT = new clszx_ConceptENEx();
clszx_ConceptBL.zx_ConceptDA.CopyTo(objzx_ConceptENS, objzx_ConceptENT);
 return objzx_ConceptENT;
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
 /// <param name = "objzx_ConceptENS">源对象</param>
 /// <returns>目标对象=>clszx_ConceptEN:objzx_ConceptENT</returns>
 public static clszx_ConceptEN CopyTo(this clszx_ConceptENEx objzx_ConceptENS)
{
try
{
 clszx_ConceptEN objzx_ConceptENT = new clszx_ConceptEN();
clszx_ConceptBL.CopyTo(objzx_ConceptENS, objzx_ConceptENT);
 return objzx_ConceptENT;
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
 /// 中学概念表(zx_Concept)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_ConceptBLEx : clszx_ConceptBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_ConceptDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_ConceptDAEx zx_ConceptDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_ConceptDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_ConceptENS">源对象</param>
 /// <returns>目标对象=>clszx_ConceptEN:objzx_ConceptENT</returns>
 public static clszx_ConceptENEx CopyToEx(clszx_ConceptEN objzx_ConceptENS)
{
try
{
 clszx_ConceptENEx objzx_ConceptENT = new clszx_ConceptENEx();
clszx_ConceptBL.zx_ConceptDA.CopyTo(objzx_ConceptENS, objzx_ConceptENT);
 return objzx_ConceptENT;
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
public static List<clszx_ConceptENEx> GetObjExLst(string strCondition)
{
List <clszx_ConceptEN> arrObjLst = clszx_ConceptBL.GetObjLst(strCondition);
List <clszx_ConceptENEx> arrObjExLst = new List<clszx_ConceptENEx>();
foreach (clszx_ConceptEN objInFor in arrObjLst)
{
clszx_ConceptENEx objzx_ConceptENEx = new clszx_ConceptENEx();
clszx_ConceptBL.CopyTo(objInFor, objzx_ConceptENEx);
arrObjExLst.Add(objzx_ConceptENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strConceptId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_ConceptENEx GetObjExByConceptId(string strConceptId)
{
clszx_ConceptEN objzx_ConceptEN = clszx_ConceptBL.GetObjByzxConceptId(strConceptId);
clszx_ConceptENEx objzx_ConceptENEx = new clszx_ConceptENEx();
clszx_ConceptBL.CopyTo(objzx_ConceptEN, objzx_ConceptENEx);
return objzx_ConceptENEx;
}
}
}